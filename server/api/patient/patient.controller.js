'use strict';

var _ = require('lodash');

// Get list of patients
exports.index = function(req, res) {
	 res.json([]);
};

exports.item = function(req, res) {
	res.json({ patientId: req.params.patientId });	
};

exports.post = function(req, res) {
	res.status(200).send('OK');
};