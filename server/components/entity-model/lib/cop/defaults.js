'use strict';

var _ = require('lodash');

module.exports = function defaults(obj, defaultValues) {
	obj = obj || {};

	for(var prop in defaultValues) {
		var defaultValue = defaultValues[prop];
		var value = obj[prop];


		if (_.isUndefined(value) || _.isNull(value)) {
			if (_.isFunction(defaultValue)) {
				defaultValue = defaultValue.call(obj, value, prop);
			}

			obj[prop] = defaultValue;
		}
	}

	return obj;
}