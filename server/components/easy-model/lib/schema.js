'use strict';

var _ = require('lodash');

module.exports = Schema;

function Schema(schema) {
	if (!(this instanceof Schema))
    	return new Schema(schema);

    schema = schema || {};

    this.table = schema.table;

    this.constraints = Schema.extractConstraints(schema.fields);
	this.defaults = Schema.extractDefaults(schema.fields);
	this.formulas = Schema.extractFormulas(schema.fields);
	this.select = Schema.extractSelectable(schema.fields);
	this.insert = Schema.extractInsertable(schema.fields);
	this.update = Schema.extractUpdatable(schema.fields);
}

Schema.extractConstraints = function extractConstraints(schema) {
	return _(schema)
		.mapValues('validation')
		.omit(function (value) { return !value; })
		.valueOf();
}

Schema.extractDefaults = function extractDefaults(schema) {
	return _(schema)
		.mapValues('default')
		.valueOf();
}

Schema.extractFormulas = function extractFormulas(schema) {
	return _(schema)
		.mapValues('formula')
		.valueOf();
}


Schema.extractSelectable = function extractSelectable(schema) {
	return _.mapValues(schema, function (value, key) {
		if (value.column) {
			return value.column;
		}
		return key;
	});
}

Schema.extractInsertable = function extractInsertable(schema) {
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

Schema.extractUpdatable = function extractUpdatable(schema) {
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