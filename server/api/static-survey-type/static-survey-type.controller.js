'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var SurveyType =  require('./static-survey-type.model');

// Get list of static-survey-types
exports.index = function(req, res, next) {
	SurveyType.find(req, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};