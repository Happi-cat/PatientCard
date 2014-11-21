'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var Promise = require('es6-promise').Promise; // jshint ignore:line
var PatientTreatmentPlan =  require('./patient-treatment-plan.model');

// Get list of patient-treatment-plans
exports.index = function(req, res, next) {
	PatientTreatmentPlan.find(req, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	});
};

exports.post = function(req, res, next) {
	var plans = _.map(req.body, function (item) {
		PatientTreatmentPlan.defaults(item);

		// Set author
		item.createdBy = req.user.username;
		item.updatedBy = req.user.username;

		return item;
	})

	var errors = _(plans).map(function (item) {
		return PatientTreatmentPlan.validate(item);
	}).compact().value();

	if (errors.length) {
		return utils.validationError(res, errors);
	}


	var promises = _.map(plans, function (item) {
		return PatientTreatmentPlan.save(req, item, { 
			patientId: item.patientId,
			optionId: item.optionId,
		})
	})

	Promise.all(promises).then(function () {
		res.status(200).send();
	}, function (err) {
		next(err);
	})
};