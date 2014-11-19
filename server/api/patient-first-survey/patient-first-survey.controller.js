'use strict';

var _ = require('lodash');
var Promise = require('es6-promise').Promise;

// Get list of patient-first-surveys
exports.index = function(req, res, next) {
	Promise.all({
		survey: findeSurvey(req),
		details: findeSurveyDetails(req),
	})
};

exports.post = function(req, res, next) {
	var item = req.models.patient(req.body);
	item.defaults();
	item.validate();

	if (item.errors) {
		return res.status(400).json(item.errors);
	}

	req.models.patientFirstSurvey.findOne({ 
		patientId: req.patientId 
	}, function (err, firstSurvey) {
		if (err) return next(err);

		req.models.patientFirstSurveyDetails.find({ 
			patientId: req.patientId 
		}, function (err, details) {
			if (err) return next(err);

			firstSurvey.details = details;
			return res.json(firstSurvey);
		})
	})

	req.models.patientFirstSurvey.create(item.value, function (err, data) {
		if (err) return next(err);
		return res.status(201).send();
	})
};

function findeSurvey(req) {
	return new Promise(function (resolve, reject) {
		req.models.patientFirstSurvey.findOne({ 
			patientId: req.patientId 
		}, function (err, data) {
			if (err) return reject(err);
			return resolve(data);
		})
	});
}

function findeSurveyDetails(req) {
	return new Promise(function (resolve, reject) {
		req.models.patientFirstSurveyDetails.find({ 
			patientId: req.patientId 
		}, function (err, data) {
			if (err) return reject(err);
			return resolve(data);
		})
	});
}