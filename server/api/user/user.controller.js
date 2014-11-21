'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var User =  require('./user.model');

// Get list of users
exports.index = function(req, res) {
  	User.find(req, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.me = function(req, req) {
	User.findOne(req, {
		username: req.user.username
	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};

exports.item = function(req, req) {
	User.findOne(req, {
		username: req.params.username
	}, function (err, data) {
		if (err) return next(err);
		return res.json(data);
	})
};