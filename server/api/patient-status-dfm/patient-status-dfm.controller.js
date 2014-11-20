'use strict';

var _ = require('lodash');

exports.index = function(req, res, next) {
  	req.models.patientStatusDfm.find({
  		patientId: req.patientId,
  	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.post = function(req, res, next) {
	var item = req.models.patientStatusDfm(req.body);

	// Who updated
	item.value.updatedBy = req.user.username;

	if (item.validate()) {
		return res.status(400).json(item.errors);
	}

	// Calculate DFM formula
	item.calculate();

	req.models.patientStatusDfm.update(item.value, { 
		id: item.value.id 
	}, function (err, data) {
		if (err) return next(err);
		return res.status(200).send();
	})
};

exports.put = function(req, res, next) {
	var item = req.models.patientStatusDfm(req.body);

	// who created
	item.value.createdBy = req.user.username;

	if (item.validate()) {
		return res.status(400).json(item.errors);
	}

	// Calculate DFM formula
	item.calculate();

	req.models.patientStatusDfm.create(item.value, function (err, data) {
		if (err) return next(err);
		return res.status(201).send();
	})
};