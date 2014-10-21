'use strict';

var _ = require('lodash');

// Get list of patient-treatment-plans
exports.index = function(req, res) {
	res.json({ patientId: req.patientId });	
};

exports.post = function(req, res) {
	res.status(200).send('OK');
};