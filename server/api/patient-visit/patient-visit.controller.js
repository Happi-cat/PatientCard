'use strict';

var _ = require('lodash');

// Get list of patient-visits
exports.index = function(req, res) {
  res.json([]);
};

exports.post = function(req, res) {
	res.status(200).send('OK');
};