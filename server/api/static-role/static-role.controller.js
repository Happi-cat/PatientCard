'use strict';

var _ = require('lodash');

// Get list of static-roles
exports.index = function(req, res, next) {
	req.models.role.find(function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};