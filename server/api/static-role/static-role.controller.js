'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var Role =  require('./static-role.model');

// Get list of static-roles
exports.index = function(req, res, next) {
	Role.find(req, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};