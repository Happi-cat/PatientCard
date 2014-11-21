'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var PatientVisit =  require('./patient-visit.model');

exports.index = function(req, res, next) {
  	PatientVisit.find(req, {
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.body;
	PatientVisit.defaults(item);

	// Who updated
	item.updatedBy = req.user.username;

	var errors = PatientVisit.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	PatientVisit.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.ok(res);
	})
};

exports.put = function(req, res, next) {
	var item = req.body;
	PatientVisit.defaults(item);
	
	// Who created
	item.createdBy = req.user.username;

	var errors = PatientVisit.validate(item);
	if (errors) {
		return utils.validationError(res, errors);
	}

	PatientVisit.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
};