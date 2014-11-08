'use strict';

var _ = require('lodash');
var mapper = require('./mapper');
var mysqlUtilities = require('mysql-utilities');

module.exports = function (schema) {
	var self = {};

	var map = mapper.buildMap(schema.fields);

	self.select = function(req, where, callback) {
		callback = callback || function () {};

		req.getConnection(function (err, connection) { 
			if (err) return callback(err, null);
			mysqlUtilities.upgrade(connection);
			mysqlUtilities.introspection(connection);

			where = mapper.convert(where, map.filter);
			
			connection.select(schema.table, '*', where, function (err, res) {
				res = mapper.convert(res, map.select);
				callback(err, res);
			});
		});
	};

	self.insert = function(req, row, callback) {
		callback = callback || function () {};

		req.getConnection(function (err, connection) { 
			if (err) return callback(err, null);
			mysqlUtilities.upgrade(connection);
			mysqlUtilities.introspection(connection);

			row = mapper.convert(row, map.insert);
			console.log (row);
			connection.insert(schema.table, row, callback);
		});
	};

	self.update = function(req, row, where, callback) {
		callback = callback || function () {};

		req.getConnection(function (err, connection) { 
			if (err) return callback(err, null);
			mysqlUtilities.upgrade(connection);
			mysqlUtilities.introspection(connection);

			row = mapper.convert(row, map.insert);
			where = mapper.convert(where, map.filter);
			
			connection.update(schema.table, row, where, callback);
		});
	};

	self.store = function(req, row, where, callback) {
		callback = callback || function () {};

		self.select(req, where, function (err, data) {
			if (err) callback(err, null);

			if (_.isObject(data[0])) {
				// smth found
				self.update(req, row, where, callback);
			}
			else {
				// nothing found
				self.insert(req, row, callback);
			}
		});
	}

	self.delete = function(req, where, callback) {
		callback = callback || function () {};

		req.getConnection(function (err, connection) { 
			if (err) return callback(err, null);
			mysqlUtilities.upgrade(connection);
			mysqlUtilities.introspection(connection);

			where = mapper.convert(where, map.filter);

			connection.delete(schema.table, where, callback);
		});
	};

	return self;
}