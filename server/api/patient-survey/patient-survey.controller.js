'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var PatientSurvey =  require('./patient-survey.model');

exports.index = function(req, res, next) {
  	PatientSurvey.find(req, {
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.body;
	PatientSurvey.defaults(item);
	
	// Who updated
	item.updatedBy = req.user.username;

	var errors = PatientSurvey.validate();
	if (errors) {
		return utils.validationError(res, errors);
	}

	PatientSurvey.update(req, item, { 
		id: item.id 
	}, function (err, data) {
		if (err) return next(err);
		return utils.ok(res);
	})
};

exports.put = function(req, res, next) {
	var item = req.body;
	PatientSurvey.defaults(item);
	
	// Who created
	item.createdBy = req.user.username;

	var errors = PatientSurvey.validate();
	if (errors) {
		return utils.validationError(res, errors);
	}

	PatientSurvey.create(req, item, function (err, data) {
		if (err) return next(err);
		return utils.created(res);
	})
};