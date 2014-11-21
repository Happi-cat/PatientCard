'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var Patient = require('./patient.model');

// Get list of patients
exports.index = function(req, res, next) {
	Patient.find(req, {}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.item = function(req, res, next) {
	Patient.findOne(req, { 
		id: req.params.patientId 
	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.body;
	Patient.defaults(item);
	
	var errors = Patient.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	Patient.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.ok(res);
	})
};

exports.put = function(req, res, next) {
	var item = req.body;
	Patient.defaults(item);	
	
	var errors = Patient.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	Patient.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
}