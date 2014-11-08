'use strict';

var _ = require('lodash');

// Get list of patients
exports.index = function(req, res, next) {
	/*req.repos.patient.select(req, null, function(err, data) {
		if (err) next(err)
		else res.json(data);
	});*/
	res.json([]);
};

exports.item = function(req, res, next) {
	/*db.select(req, { 
		id: req.params.patientId 
	}, function(err, data) {
		if (err) next(err)
		else res.json(data[0]);
	});*/
	res.json({});
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