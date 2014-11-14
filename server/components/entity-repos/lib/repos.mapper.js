'use strict';

var _ = require('lodash');



module.exports = mapper;

function mapper(fields) {
	return {
		select: mapper.buildSelectMap(fields),
		insert: mapper.buildInsertMap(fields),
		update: mapper.buildUpdateMap(fields),
	};
}

mapper.buildSelectMap = function buildSelectMap(fields) {
	return _.mapValues(fields, function (value, key) {
		if (value.column) {
			return value.column;
		}
		return key;
	});
}

mapper.buildInsertMap = function buildInsertMap(fields) {
	return _(fields)
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

mapper.buildUpdateMap = function buildUpdateMap(fields) {
	return _(fields)
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