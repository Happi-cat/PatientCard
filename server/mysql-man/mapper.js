'use strict';

var _ = require('lodash');

module.exports.buildMap = function (fields) {
	var map = {
		select: {},
		insert: {},
		update: {},
		filter: {},
	};

	_.transform(fields, function (result, value, key) {
		if (_.isString(value)) {
			// add to all sub-maps
			result.select[key] = value;
			result.insert[value] = key;
			result.update[value] = key;
			result.filter[value] = key;
		} else if (_.isObject(value) && _.isString(value.prop)) {
			// has prop name
			result.select[key] = value.prop;
			result.filter[value.prop] = key;

			if (value.insertable) {
				result.insert[value.prop] = key;
			}
			if (value.updatable) {
				result.update[value.prop] = key;
			}
		}
	}, map);

	return map;
};

module.exports.convert = function (obj, map) {
	if (_.isArray(obj)) {
		return _.map(obj, function (item) {
			return _.transform(item, function (result, value, key) {
				var newProp = map[key];
				if (!!newProp) {
					result[newProp] = value;
				}
			});
		});
	} 
	if (_.isObject(obj)) {
		return _.transform(obj, function (result, value, key) {
			var newProp = map[key];
			if (!!newProp) {
				result[newProp] = value;
			}
		});
	}
};
