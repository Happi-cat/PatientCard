'use strict';

var _ = require('lodash');
var Cop = require('./../entity-cop');

module.exports = function (name, schema) {
	var cop = new Cop(schema.fields);

	return function (req, res, next) {
		req.cops = req.cops || {};
		req.cops[name] = cop;
		next();
	};
}