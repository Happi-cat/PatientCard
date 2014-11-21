'use strict';

var _ = require('lodash');
var query = require('./query/query-builder');

module.exports = Repos;

function Repos(schema) {
	this.maps = {
		select: schema.select,
		insert: schema.insert,
		update: schema.update
	};
	this.table = schema.table;
}

Repos.prototype.find = function select(req, where, done) {
	var self = this;

	if (_.isFunction(where)) {
		done = where;
		where = null;
	}

	req.getConnection(function (err, connection) {
		if (err) return done(err, null);

		var sql = query(self.maps)
			.select()
			.columns()
			.from(self.table)
			.where(where)
			.compile();

		console.log(sql);

		connection.query(sql, done);
	});
}

Repos.prototype.findOne = function select(req, where, done) {
	var self = this;

	if (_.isFunction(where)) {
		done = where;
		where = null;
	}

	req.getConnection(function (err, connection) {
		if (err) return done(err, null);

		var sql = query(self.maps)
			.select()
			.columns()
			.from(self.table)
			.where(where)
			.limit(1)
			.compile();
		connection.query(sql, function (err, data) {
			if (err) return done(err, null);
			return done(null, data[0]);
		});
	});
}

Repos.prototype.create = function create(req, obj, done) {
	var self = this;
	req.getConnection(function (err, connection) {
		if (err) return done(err, null);

		var sql = query(self.maps)
			.insert()
			.into(self.table)
			.values(obj)
			.compile();
		connection.query(sql, done);
	});
}

Repos.prototype.update = function update(req, obj, where, done) {
	var self = this;
	req.getConnection(function (err, connection) {
		if (err) return done(err, null);

		var sql = query(self.maps)
			.update()
			.table(self.table)
			.set(obj, true)
			.where(where)
			.compile();
		connection.query(sql, done);
	});
}

Repos.prototype.save = function save(req, obj, where, done) {
	var self = this;
	self.findOne(req, where, function (err, data) {
		if (err) return done(err);
		
		if (_.isEmpty(data)) {
			return self.create(req, obj, done);
		} else {
			return self.update(req, obj, where, done);
		}
	});
}

Repos.prototype.delete = function $delete(req, where, done) {
	var self = this;
	req.getConnection(function (err, connection) {
		if (err) return done(err, null);

		var sql = query(self.maps)
			.delete()
			.from(self.table)
			.where(where)
			.compile();
		connection.query(sql, done);
	});
}