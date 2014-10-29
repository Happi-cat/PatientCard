'use strict';

var _ = require('lodash');
var validate = require('./patient.validate');

// Get list of patients
exports.index = function(req, res) {
	 res.json([{
	 	id: 1,
	 	firstName: 'Иван',
	 	lastName: 'Пупкин',
	 	displayName: 'Пупкин Иван',
	 }]);
};

exports.item = function(req, res) {
	res.json({ 
		patientId: req.params.patientId,
		firstName: 'Иван',
	 	lastName: 'Пупкин',
	 	displayName: 'Пупкин Иван',
	});	
};

exports.post = function(req, res) {
	res.status(200).send('OK');
};