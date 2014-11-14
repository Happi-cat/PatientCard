'use strict';

var _ = require('lodash');
var validators = require('./cop.validators');

module.exports = Cop;

function Cop (schema) {
	this.constraints = Cop.getConstraints(schema);
	this.defaultValues = Cop.getDefaultValues(schema);
}

Cop.getDefaultValues = function getDefaultValues(schema) {
	schema = schema || {};
	return _(schema)
		.mapValues('default')
		.valueOf();
}

Cop.getConstraints = function getConstraints(schema) {
	schema = schema || {};
	return _(schema)
		.mapValues('validation')
		.omit(function (value) { return !value; })
		.valueOf();
}

Cop.prototype.defaults = function defaults(obj) {
	obj = obj || {};

	for(var prop in this.defaultValues) {
		var defaultValue = this.defaultValues[prop];
		var value = obj[prop];
		console.log(prop);


		if (_.isUndefined(value)) {
			if (_.isFunction(defaultValue)) {
				defaultValue = defaultValue.call(obj, prop);
			}

			obj[prop] = defaultValue;
			console.log(prop, obj[prop]);
		}
	}

	return obj;
}

Cop.prototype.validate = function validate(obj) {
	obj = obj || {};
	var results = this.runValidation(obj);
	return this.processResults(results);
}

Cop.prototype.runValidation = function runValidation(obj) {
	var results = [];

	for(var prop in this.constraints) {
		var validators = this.constraints[prop];
		var value = obj[prop];

		for (var validatorName in validators) {
			var validator = Cop.validators[validatorName];
			var validatorOpts = validators[validatorName];

			if (!_.isFunction(validator)) {
				throw new Error("Invalid or unkown validator " + validatorName);
			}

			// compute options and pass this = obj;
			if (_.isFunction(validatorOpts)) {
				validatorOpts = validatorOpts.call(obj, value, prop);
			}

			// Skip if empty opts
			if (!validatorOpts) {
				continue;
			}
			results.push({
				prop: prop,
				error: validator.call(validator, value, validatorOpts),
			});
		}
	}

	return results;
}

Cop.prototype.processResults = function processResults(results) {
	var errors = {};
	var invalid = false;

	_.transform(results, function (result, item) {
		if (_.isString(item.error)) {
			invalid = true;
			// create prop array
			result[item.prop] = result[item.prop] || [];
			//generate error
			result[item.prop].push(Cop.generateMessage(item));
		}
	}, errors);

	if (invalid) {
		return errors;
	}
}

Cop.generateMessage = function generateMessage(item) {
	return item.prop + " " + item.error;
}

Cop.validators = validators;