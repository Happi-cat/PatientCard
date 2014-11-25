'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var PatientStatusOhis =  require('./patient-status-ohis.model');

exports.index = function(req, res, next) {
  	PatientStatusOhis.find(req, {
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.create = function(req, res, next) {
	var item = req.body;
	PatientStatusOhis.defaults(item);

	// Who created
	item.createdBy = req.user.username;

	var errors = PatientStatusOhis.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	// Calculate OHIS formula
	PatientStatusOhis.calculate(item);

	PatientStatusOhis.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
}

exports.update = function(req, res, next) {
	var item = req.body;
	PatientStatusOhis.defaults(item);
	
	// Who updated
	item.updatedBy = req.user.username;

	var errors = PatientStatusOhis.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	// Calculate OHIS formula
	PatientStatusOhis.calculate(item);

	PatientStatusOhis.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.updated(res);
	})
};