'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var FirstSurveyOption =  require('./static-first-survey-option.model');

// Get list of static-first-survey-options
exports.index = function(req, res, next) {
	FirstSurveyOption.find(req, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};