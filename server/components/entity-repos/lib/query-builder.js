'use strict';

var _ = require('lodash');
var compiler = require('./query-compiler');

module.exports = function query(maps) {
	return new QueryBuilder(maps);
}

function QueryBuilder(maps) {
	this.maps = maps;
	this.query = {
		operation: 'select',
		columns: [],
		table: null,
		wheres: [],
		values: [],
		limit: false,
	};
}

QueryBuilder.prototype.select = function select() {
	this.query.operation = 'select';
	return this;
}

QueryBuilder.prototype.columns = function columns() {
	var map = this.maps.select;
	for(var prop in map) {
		var column = map[prop];

		if (!column) {
			throw new Error('wrong column');
		}

		this.query.columns.push({
			column: column,
			as: prop,
		});
	}
	return this;
}

QueryBuilder.prototype.update = function update() {
	this.query.operation = 'update';
	return this;
}

QueryBuilder.prototype.insert = function insert() {
	this.query.operation = 'insert';
	return this;
}

QueryBuilder.prototype.delete = function $delete() {
	this.query.operation = 'delete';
	return this;
}

QueryBuilder.prototype.where = function where(filter) {
	filter = filter || {};
	
	var map = this.maps.select;
	for (var prop in filter) {
		var column = map[prop];
		var value = filter[prop];
		
		if (!column) {
			continue;
		}
		this.query.wheres.push({
			column: column,
			value: value,
			operator: '=',
		});
	}
	
	return this;
}

QueryBuilder.prototype.limit = function limit(count) {
	this.query.limit = count;
	return this;
}

QueryBuilder.prototype.table = 
QueryBuilder.prototype.into = 
QueryBuilder.prototype.from = function from(table) {
	this.query.table = table;
	return this;
}

QueryBuilder.prototype.values = function values(obj) {
	if (this.query.operation !== 'insert') {
		throw new Error('"values" method can be called only for insert operation');
	}

	if (_.isObject(obj)) {
		var map = this.maps.insert;
		for (var prop in map) {
			var column = map[prop];
			var value = obj[prop];

			if (!column) {
				throw new Error('wrong column');
			}

			this.query.values.push({
				column: column,
				value: value,
			});
		}
	}

	return this;
}

QueryBuilder.prototype.set = function set(obj, updateAll) {
	if (this.query.operation !== 'update') {
		throw new Error('"set" method can be called only for update operation');
	}

	if (_.isObject(obj)) {
		var map = this.maps.update;
		var props = updateAll ? map : obj;
		
		for (var prop in props) {
			var column = map[prop];
			var value = obj[prop];

			if (!column) {
				throw new Error('wrong column');
			}
						
			this.query.values.push({
				column: column,
				value: value,
			});
		}
	}

	return this;
}

QueryBuilder.prototype.compile = function compile() {
	var t= compiler(this.query);
	console.log(t);
	return t;
};