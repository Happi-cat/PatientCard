'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var PatientStatusCpi = require('./patient-status-cpi.model');

exports.index = function(req, res, next) {
  	PatientStatusCpi.find(req, {
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.create = function(req, res, next) {
	var item = req.body;
	PatientStatusCpi.defaults(item);	
	
	// Who created
	item.createdBy = req.user.username;

	var errors = PatientStatusCpi.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	// Compute  CPI formulas
	PatientStatusCpi.calculate(item);

	PatientStatusCpi.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
}

exports.update = function(req, res, next) {
	var item = req.body;
	PatientStatusCpi.defaults(item);
	
	// Who updated 
	item.updatedBy = req.user.username;

	var errors = PatientStatusCpi.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	// Compute  CPI formulas
	PatientStatusCpi.calculate(item);

	PatientStatusCpi.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.updated(res);
	})
};