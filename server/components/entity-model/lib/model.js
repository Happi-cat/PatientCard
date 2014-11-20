'use strict';

var calculate = require('./cop/calculate');
var defaults = require('./cop/defaults');
var validate = require('./cop/validate');

module.exports = Model;

function Model(obj, schema) {
	this.schema = schema || {};
	this.value = obj;
	this.errors = null;
}

Model.prototype.validate = function () {
	this.errors = validate(this.value, this.schema.constraints);

	return this.errors;
}

Model.prototype.defaults = function() {
	this.value = defaults(this.value, this.schema.defaults);

	return this;
}

Model.prototype.calculate = function() {
	this.value = calculate(this.value, this.schema.formulas);

	return this;
}
