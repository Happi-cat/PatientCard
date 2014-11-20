'use strict';

var Model = require('./lib/model');
var Repos = require('./lib/repos');
var mapper = require('./lib/mapper');

module.exports = function (schema) {
	schema = mapper(schema);

	function model(obj) {
		var wrapped = new Model(obj, schema);
		
		wrapped.defaults();
		
		return wrapped;
	}
	model.db = new Repos(schema);

	return model;
}
