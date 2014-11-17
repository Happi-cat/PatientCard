'use strict';

var _ = require('lodash');

module.exports = function (name, schema) {
	var model = require('./../entity-model')(schema);

	return function (req, res, next) {
		req.models = req.models || {};

		req.models[name] = model;

		model.find = function (where, done) {
			return model.db.find(req, where, done);
		};
		model.findOne= function (where, done) {
			return model.db.findOne(req, where, done);
		};
		model.create= function (obj, done) {
			return model.db.create(req, obj, done);
		};
		model.update= function (obj, where, done) {
			return model.db.update(req, obj, where, done);
		};
		model.delete= function (where, done) {
			return model.db.delete(req, where, done);
		};

		next();
	};
}