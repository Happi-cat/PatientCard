'use strict';

var _ = require('lodash');

module.exports = Repos;

function Repos(schema) {
	this.table = scheme.table;
}

Repos.getSelectable = function getSelectable(schema) {
	return _.mapValues(schema.fields, function (value, key) {
		if (value.column) {
			return value.column;
		}
		return key;
	});
}

Repos.getInsertable = function getInsertable(schema) {
	return _(schema.fields)
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

Repos.getUpdatable = function getUpdatable(schema) {
	return _(schema.fields)
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

Repos.prototype.select = function select(req, where, done) {
	req.getConnection(function (err, connection) {
		if (err) return done(err, null);

		connection.query
	});
}

Repos.prototype.create = function create(req, obj, done) {

}

Repos.prototype.update = function update(req, obj, where, done) {

}

Repos.prototype.delete = function delete(req, where, done) {

}