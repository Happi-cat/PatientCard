'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var PatientStatusDentist =  require('./patient-status-dentist.model');

exports.index = function(req, res, next) {
  	PatientStatusDentist.find(req, {
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.body;
	PatientStatusDentist.defaults(item);
	
	// Who updated
	item.updatedBy = req.user.username;

	var errors = PatientStatusDentist.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	PatientStatusDentist.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.ok(res);
	})
};

exports.put = function(req, res, next) {
	var item = req.body;
	PatientStatusDentist.defaults(item);
	
	// Who created
	item.createdBy = req.user.username;

	var errors = PatientStatusDentist.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	PatientStatusDentist.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
};