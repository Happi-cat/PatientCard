'use strict';

var _ = require('lodash');

exports.index = function(req, res, next) {
  	req.models.patientStatusDentist.find({
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.models.patientStatusDentist(req.body);
	item.calculate();
	item.validate();
	
	if (item.errors) {
		return res.status(400).json(item.errors);
	}

	req.models.patientStatusDentist.update(item.value, { 
		id: item.value.id 
	}, function (err, data) {
		if (err) return next(err);
		return res.status(200).send();
	})
};

exports.post = function(req, res, next) {
	var item = req.models.patientStatusDentist(req.body);
	item.defaults();
	item.calculate();
	item.validate();
	
	if (item.errors) {
		return res.status(400).json(item.errors);
	}

	req.models.patientStatusDentist.create(item.value, function (err, data) {
		if (err) return next(err);
		return res.status(201).send();
	})
};