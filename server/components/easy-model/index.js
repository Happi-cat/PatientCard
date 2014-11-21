'use strict';

var Model = require('./lib/model');

var Schema = require('./lib/schema');

function ModelManger() {
	this.models = [];
}

ModelManger.prototype.model = function(name, schema) {		
	this.models[name] = new Model(schema);
	return this.models[name];
};

ModelManger.prototype.Schema = Schema;

module.exports = new ModelManger();