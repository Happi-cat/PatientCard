'use strict';

var _ = require('lodash');
var Cop = require('./../entity-cop');
var Repos = require('./../entity-repos');

module.exports = function (name, schema) {
	var cop = new Cop(schema.fields);
	var repos = new Repos(schema);

	return function (req, res, next) {
		req.models = req.models || {};

		req.models[name] = {
			validate: function (obj) {
				return cop.validate(obj);
			},
			defaults: function (obj) {
				return cop.defaults(obj);
			}
			find: function (where, done) {
				return repos.find(req, where, done);
			},
			findOne: function (where, done) {
				return repos.findOne(req, where, done);
			},
			create: function (obj, done) {
				return repos.create(req, obj, done);
			},
			update: function (where ,obj, done) {
				return repos.update(req, where, obj, done);
			},
			delete: function (where, done) {
				return repos.delete(req, where, done);
			}
		};

		next();
	};
}