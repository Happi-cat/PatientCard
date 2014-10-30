'use strict';

var _ = require('lodash');
var schema = require('./static-survey-type.schema.json');
var db = require('../../mysql-man')(schema);

// Get list of static-survey-types
exports.index = function(req, res, next) {
	db.select(req, null, function(err, data) {
		if (err) next(err)
		else res.json(data);
	})
};