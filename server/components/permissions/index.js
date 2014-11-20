'use strict';

var _ = require('lodash');

var ERR_UNAUTHORIZED = 401;
var ERR_FORBIDDEN = 403;

module.exports.auth = function () {
	return function checkAuth (req, res, next) {
		if (req.user && req.user.username) {
			return next();
		}
		
		res.status(ERR_UNAUTHORIZED).send();
	}
}

module.exports.roles = function (roles) {
	if (!_.isArray(roles)) {
		roles = [roles];
	}

	return function checkRoles(req, res, next) {
		var user = req.user || {};
		
		if (!user.username) {
			return res.status(ERR_UNAUTHORIZED).send();
		}

		// No roles specified, means just check auth
		if (roles.length) {
			if (_.contains(roles, user.role)) {
				return next();
			}
		} else {
			return next();
		}

		res.status(ERR_FORBIDDEN).send();
	}
}
