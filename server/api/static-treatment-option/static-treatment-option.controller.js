'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var TreatmentOption =  require('./static-treatment-option.model');

// Get list of static-treatment-options
exports.index = function(req, res, next) {
  	TreatmentOption.find(req, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};