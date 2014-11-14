'use strict';

var _ = require('lodash');

// Get list of static-treatment-options
exports.index = function(req, res, next) {
  	req.models.treatmentOption.find(function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};