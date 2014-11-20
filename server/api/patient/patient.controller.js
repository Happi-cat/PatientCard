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
	req.models.patient.findOne({ 
		id: req.params.patientId 
	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.models.patient(req.body);
	
	if (item.validate()) {
		return res.status(400).json(item.errors);
	}

	req.models.patient.update(item.value, { 
		id: item.value.id 
	}, function (err, data) {
		if (err) return next(err);
		return res.status(200).send();
	})
};

exports.put = function(req, res, next) {
	var item = req.models.patient(req.body);	
	
	if (item.validate()) {
		return res.status(400).json(item.errors);
	}

	req.models.patient.create(item.value, function (err, data) {
		if (err) return next(err);
		return res.status(201).send();
	})
}