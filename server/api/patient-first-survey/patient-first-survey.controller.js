'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var Promise = require('es6-promise').Promise; // jshint ignore:line
var PatientFirstSurvey =  require('./patient-first-survey.model');
var PatientFirstSurveyDetails =  require('./patient-first-survey.details.model');

// Get list of patient-first-surveys
exports.index = function(req, res, next) {
	PatientFirstSurvey.findOne(req, { 
		patientId: req.patientId 
	}, function (err, firstSurvey) {
		if (err) return next(err);

		firstSurvey = firstSurvey || {};

		PatientFirstSurveyDetails.find(req, { 
			patientId: req.patientId 
		}, function (err, details) {
			if (err) return next(err);

			firstSurvey.details = details;
			return res.json(firstSurvey);
		})
	})
};

exports.post = function(req, res, next) {
	var item = req.body;	
	PatientFirstSurvey.defaults(item);

	var details = req.body.details;
	PatientFirstSurveyDetails.defaults(details);


	var errors = PatientFirstSurvey.validate();
	var detailsErrors = _(details).map(function (item) {
		return PatientFirstSurveyDetails.validate(item);
	}).compact().value();

	if (errors) {
		return utils.validationError(res, errors);
	}
	if (detailsErrors.length) {
		return utils.validationError(res, detailsErrors);
	}


	PatientFirstSurvey.save(req, item, { 
		patientId: req.patientId 
	}).then(function () {
		var promises = _.map(details, function (detail) {
			return PatientFirstSurveyDetails.save(req, detail, { 
				patientId: detail.patientId,
				optionId: detail.optionId,
			})
		})

		return Promise.all(promises);
	}).then(function () {
		res.status(200).send();
	}, function (err) {
		next(err);
	})
};