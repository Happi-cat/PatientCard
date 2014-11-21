'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var PatientStatusDfm =  require('./patient-status-dfm.model');

exports.index = function(req, res, next) {
  	PatientStatusDfm.find(req, {
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.body;
	PatientStatusDfm.defaults(item);

	// Who updated
	item.updatedBy = req.user.username;

	var errors = PatientStatusDfm.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	// Calculate DFM formula
	PatientStatusDfm.calculate(item);

	PatientStatusDfm.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.ok(res);
	})
};

exports.put = function(req, res, next) {
	var item = req.body;
	PatientStatusDfm.defaults(item);

	// who created
	item.createdBy = req.user.username;

	var errors = PatientStatusDfm.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	// Calculate DFM formula
	PatientStatusDfm.calculate(item);

	PatientStatusDfm.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
};