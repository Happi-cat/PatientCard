'use strict';

var _ = require('lodash');
var Promise = require('es6-promise').Promise; // jshint ignore:line

// Get list of patient-first-surveys
exports.index = function(req, res, next) {
	req.models.patientFirstSurvey.findOne({ 
		patientId: req.patientId 
	}, function (err, firstSurvey) {
		if (err) return next(err);

		firstSurvey = firstSurvey || {};

		req.models.patientFirstSurveyDetails.find({ 
			patientId: req.patientId 
		}, function (err, details) {
			if (err) return next(err);

			firstSurvey.details = details;
			return res.json(firstSurvey);
		})
	})
};

exports.post = function(req, res, next) {
	var item = req.models.patientFirstSurvey(req.body);	

	var details = _.map(req.body.details, function (item) {
		return req.models.patientFirstSurveyDetails(item);
	})

	var detailsErrors = _(details).map(function (item) {
		return item.validate();
	}).compact().value();

	if (item.validate()) {
		return res.status(400).json(item.errors);
	}
	if (detailsErrors.length) {
		return res.status(400).json(detailsErrors);
	}


	req.models.patientFirstSurvey.save( item.value, { 
		patientId: req.patientId 
	}).then(function () {
		var promises = _.map(details, function (detail) {
			return req.models.patientFirstSurveyDetails.save(detail.value, { 
				patientId: detail.value.patientId,
				optionId: detail.value.optionId,
			})
		})

		return Promise.all(promises);
	}).then(function () {
		res.status(200).send();
	}, function (err) {
		next(err);
	})
};