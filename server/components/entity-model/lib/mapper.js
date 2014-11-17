'use strict';

var _ = require('lodash');

module.exports = map;

function map(schema) {
	return {
		table: schema.table,
		constraints: map.getConstraints(schema.fields),
		defaults: map.getDefaults(schema.fields),
		formulas: map.getFormulas(schema.fields),
		select: map.getSelectable(schema.fields),
		insert: map.getInsertable(schema.fields),
		update: map.getUpdatable(schema.fields),
	}
}

map.getConstraints = function getConstraints(schema) {
	schema = schema || {};
	return _(schema)
		.mapValues('validation')
		.omit(function (value) { return !value; })
		.valueOf();
}

map.getDefaults = function getDefaults(schema) {
	schema = schema || {};
	return _(schema)
		.mapValues('default')
		.valueOf();
}

map.getFormulas = function getFormulas(schema) {
	schema = schema || {};
	return _(schema)
		.mapValues('formula')
		.omit(function (value) { return !_.isFunction(value); })
		.valueOf();
}


map.getSelectable = function getSelectable(schema) {
	return _.mapValues(schema, function (value, key) {
		if (value.column) {
			return value.column;
		}
		return key;
	});
}

map.getInsertable = function getInsertable(schema) {
	return _(schema)
	.mapValues(function (value, key) {
		if (value.notInsert) {
			return;
		}

		if (value.column) {
			return value.column;
		}
		return key;
	})
	.omit (function (value) { return !value; })
	.valueOf();
}

map.getUpdatable = function getUpdatable(schema) {
	return _(schema)
	.mapValues(function (value, key) {
		if (value.notUpdate) {
			return;
		}

		if (value.column) {
			return value.column;
		}
		return key;
	})
	.omit (function (value) { return !value; })
	.valueOf();
}