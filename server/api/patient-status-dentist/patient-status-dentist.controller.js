'use strict';

var _ = require('lodash');
var validate = require('./patient-status-dentist.validate');

// Get list of patient-status-dentists
exports.index = function(req, res) {
  res.json([]);
};

exports.post = function(req, res) {
	res.status(200).send('OK');
};