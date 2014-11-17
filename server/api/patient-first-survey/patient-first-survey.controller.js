'use strict';

var _ = require('lodash');

// Get list of patient-first-surveys
exports.index = function(req, res. next) {
	req.models.patientFirstSurvey.findOne({ 
		patientId: req.params.patientId 
	}, function (err, firstSurvey) {
		if (err) return next(err);

		req.models.patientFirstSurveyDetails.find({ 
			patientId: req.params.patientId 
		}, function (err, details) {
			if (err) return next(err);

			firstSurvey.details = details;
			return res.json(firstSurvey);
		})
	})	
};

exports.post = function(req, res, next) {
	var item = req.models.patient(req.body);
	item.validate();

	if (item.errors) {
		return res.status(400).json(item.errors);
	}

	req.models.patientFirstSurvey.update(item.value, { 
		id: item.value.id 
	}, function (err, data) {
		if (err) return next(err);
		return res.status(200).send();
	})
};

exports.put = function(req, res, next) {
	var item = req.models.patient(req.body);
	item.defaults();
	item.validate();

	if (item.errors) {
		return res.status(400).json(item.errors);
	}

	req.models.patientFirstSurvey.create(item.value, function (err, data) {
		if (err) return next(err);
		return res.status(201).send();
	})
};

function saveDetails(req, res, next) {
	
}