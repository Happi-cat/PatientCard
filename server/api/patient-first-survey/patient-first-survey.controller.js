'use strict';

var _ = require('lodash');
var validate = require('./patient-first-survey.validate');

// Get list of patient-first-surveys
exports.index = function(req, res) {
	res.json({ 
		patientId: req.patientId 
	});	
};

exports.post = function(req, res) {
	res.status(200).send('OK');
};