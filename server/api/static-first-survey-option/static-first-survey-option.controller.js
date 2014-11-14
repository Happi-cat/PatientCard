'use strict';

var _ = require('lodash');

// Get list of static-first-survey-options
exports.index = function(req, res, next) {
	req.models.firstSurveyOption.find(function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};