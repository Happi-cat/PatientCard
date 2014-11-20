'use strict';

var _ = require('lodash');
var Promise = require('es6-promise').Promise; // jshint ignore:line

// Get list of patient-treatment-plans
exports.index = function(req, res, next) {
	req.models.patientTreatmentPlan.find({}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	});
};

exports.post = function(req, res, next) {
	var plans = _.map(req.body, function (item) {
		var plan = req.models.patientTreatmentPlan(item);

		// Set author
		plan.value.createdBy = req.user.username;
		plan.value.updatedBy = req.user.username;

		return plan;
	})

	var errors = _(plans).map(function (plan) {
		return plan.validate();
	}).compact().value();

	if (errors.length) {
		return res.status(400).json(errors);
	}


	var promises = _.map(plans, function (plan) {
		return req.models.patientTreatmentPlan.save(plan.value, { 
			patientId: plan.value.patientId,
			optionId: plan.value.optionId,
		})
	})

	Promise.all(promises).then(function () {
		res.status(200).send();
	}, function (err) {
		next(err);
	})
};