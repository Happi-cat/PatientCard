'use strict';

var _ = require('lodash');

// Get list of patients
exports.index = function(req, res, next) {
	req.models.patient.find({}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.item = function(req, res, next) {
	req.models.patient.findOne({ id: req.params.patientId }, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.body;
	var errors = req.models.patient.validate(req.body);
	
	if (errors) {
		return res.status(400).json(errors);
	}

	req.models.patient.update(req.body, { id: req.body.id }, function (err, data) {
		if (err) return next(err);
		return res.status(200).send();
	})
};

exports.put = function(req, res, next) {
	var item = req.models.patient.defaults(req.body);
	var errors = req.models.patient.validate(item);
	console.log(item);
	if (errors) {
		return res.status(400).json(errors);
	}

	req.models.patient.create(item, function (err, data) {
		if (err) return next(err);
		return res.status(201).send();
	})
}