'use strict';

var _ = require('lodash');
var validators = require('./validators');

module.exports = validate;

function validate(obj, constraints) {
	obj = obj || {};
	var results = validate.runValidation(obj, constraints);
	return validate.processResults(results);
}

validate.validators = validators;

validate.runValidation = function runValidation(obj, constraints) {
	var results = [];

	for(var prop in validate.constraints) {
		var validators = validate.constraints[prop];
		var value = obj[prop];

		for (var validatorName in validators) {
			var validator = validate.validators[validatorName];
			var validatorOpts = validators[validatorName];

			if (!_.isFunction(validator)) {
				throw new Error("Invalid or unkown validator " + validatorName);
			}

			// compute options and pass validate = obj;
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

validate.processResults = function processResults(results) {
	var errors = {};
	var invalid = false;

	_.transform(results, function (result, item) {
		if (_.isString(item.error)) {
			invalid = true;
			// create prop array
			result[item.prop] = result[item.prop] || [];
			//generate error
			result[item.prop].push(validate.generateMessage(item));
		}
	}, errors);

	if (invalid) {
		return errors;
	}
}

validate.generateMessage = function generateMessage(item) {
	return item.prop + " " + item.error;
}