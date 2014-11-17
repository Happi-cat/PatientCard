'use strict';

var _ = require('lodash');
var mysql = require('mysql');

module.exports = function compiler(query) {
	return (new QueryCompiler(query)).toSql();
}

function QueryCompiler(query) {
	this.query = query;
}

QueryCompiler.prototype.toSql = function() {
	return this[this.query.operation]();
}

QueryCompiler.prototype.columns = function() {
	return _.map(this.query.columns, function (item) {
		if (item.column === item.as) {
			return mysql.escapeId(item.column);
		}

		return mysql.escapeId(item.column) + ' AS ' + mysql.escapeId(item.as);
	}).join(', ') || '*';
};

QueryCompiler.prototype.select = function select() {
	return ['SELECT', this.columns(), 'FROM', this.query.table, this.where(), this.limit()].join(' ').trim();
}

QueryCompiler.prototype.insert = function insert() {
	var cols = [];
	var vals = [];

	_.forEach(this.query.values, function (item){
		cols.push(mysql.escapeId(item.column));
		vals.push(mysql.escape(item.value));
	});

	if (!cols) {
		throw new Error('nothing to insert');
	}

	cols = cols.join(', ');
	vals = vals.join(', ');

	return ['INSERT INTO', this.query.table, '(', cols, ') VALUES (', vals, ')'].join(' ').trim();
}

QueryCompiler.prototype.update = function update() {
	var sets = _.map(this.query.values, function (item){
		return mysql.escapeId(item.column) + ' = ' + mysql.escape(item.value);
	}).join(', ');

	if (!sets) {
		throw new Error('nothing to update');
	}	

	return ['UPDATE', this.query.table, 'SET', sets, this.where()].join(' ').trim();
}

QueryCompiler.prototype.delete = function $delete() {
	return ['DELETE FROM', this.query.table, this.where()].join(' ').trim();	
}

QueryCompiler.prototype.where = function where() {
	var wheres = _.map(this.query.wheres, function (item){
		return mysql.escapeId(item.column) + ' ' + item.operator + ' ' + mysql.escape(item.value);
	});
	if (wheres.length) {
		return 'WHERE ' + wheres.join(' AND ');
	}
}

QueryCompiler.prototype.limit = function limit() {
	if (this.query.limit)
	{
		return 'LIMIT ' + this.query.limit;
	}
}