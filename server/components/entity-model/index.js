'use strict';

var Model = require('./lib/model');
var Repos = require('./lib/repos');
var mapper = require('./lib/mapper');

module.exports = function (schema) {
	schema = mapper(schema);

	function model(obj) {
		return new Model(obj, schema)
	}
	model.db = new Repos(schema);

	return model;
}
