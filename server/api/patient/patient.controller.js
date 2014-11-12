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
	req.models.patient.findOne({ id: req.params.patientId }, function (err, data) {
		if (err) return next(err);
		return res.json(data[0]);
	})
};

exports.post = function(req, res, next) {
	/*if (_.isNumber(req.body.id) && validator(req.body)) {
		db.update(req, req.body, { id: req.body.id }, function(err, data) {
			if (err) next(err);
			else res.status(200).send();
		});
	} else {
		res.status(400).send();
	}*/
	res.status(200).send();
};

exports.put = function(req, res, next) {
	/*if (validator(req.body)) {
		db.insert(req, req.body, function(err, data) {
			if (err) next(err);
			else res.status(201).send();
		});
	} else {
		res.status(400).send();
	}*/		
	res.status(201).send();
}