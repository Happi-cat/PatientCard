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

			row = mapper.convert(row, map.insert);

			connection.insert(schema.table, row, callback);
		});
	};

	self.update = function(req, row, where, callback) {
		callback = callback || function () {};

		req.getConnection(function (err, connection) { 
			if (err) return callback(err, null);
			mysqlUtilities.upgrade(connection);

			row = mapper.convert(row, map.insert);
			where = mapper.convert(where, map.filter);

			connection.update(schema.table, row, where, callback);
		});
	};

	self.delete = function(req, where, callback) {
		callback = callback || function () {};

		req.getConnection(function (err, connection) { 
			if (err) return callback(err, null);
			mysqlUtilities.upgrade(connection);

			where = mapper.convert(where, map.filter);

			connection.delete(schema.table, where, callback);
		});
	};

	return self;
}