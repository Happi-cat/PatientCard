'use strict';

var _ = require('lodash');

// Get list of static-survey-types
exports.index = function(req, res, next) {
	req.models.surveyType.find(function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};