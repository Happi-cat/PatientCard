'use strict';

var _ = require('lodash');
var Promise = require('es6-promise').Promise; // jshint ignore:line

var Repos = require('./repos');
var Schema = require('./schema');

var calculate = require('./cop/calculate');
var defaults = require('./cop/defaults');
var validate = require('./cop/validate');

var noop = function() {};

module.exports = Model;

/**
 * Creates new model with defined schema
 */
function Model(schema) {
	if (!(schema instanceof Schema)) throw new TypeError('Wrong schema type');

	this.schema = schema;
	this.repos = new Repos(schema);
}

Model.prototype.validate = function(obj) {
	if (_.isArray(obj)) {
		return _.map(obj, function (item) {
			return validate(item, this.schema.constraints);			
		})
	}
	return validate(obj, this.schema.constraints);
}

Model.prototype.defaults = function(obj) {
	if (_.isArray(obj)) {
		return _.map(obj, function (item) {
			return defaults(item, this.schema.defaults);			
		})
	}
	return defaults(obj, this.schema.defaults);
}

Model.prototype.calculate = function(obj) {
	if (_.isArray(obj)) {
		return _.map(obj, function (item) {
			return calculate(item, this.schema.formulas);			
		})
	}
	return calculate(obj, this.schema.formulas);
}

Model.prototype.find = function select(req, where, done) {
	var repos = this.repos;
	done = done || noop;
    return new Promise(function(resolve, reject) {
        repos.find(req, where, function(err, data) {
            if (err) reject(err);
            else resolve(data);

            done(err, data);
        });
    });
}
Model.prototype.findOne = function select(req, where, done) {
	var repos = this.repos;
	done = done || noop;
    return new Promise(function(resolve, reject) {
        repos.findOne(req, where, function(err, data) {
            if (err) reject(err);
            else resolve(data);

            done(err, data);
        });
    });
}
Model.prototype.create = function create(req, obj, done) {
	var repos = this.repos;
	done = done || noop;
    return new Promise(function(resolve, reject) {
        repos.create(req, obj, function(err, data) {
            if (err) reject(err);
            else resolve(data);

            done(err, data);
        });
    });
}
Model.prototype.update = function update(req, obj, where, done) {
	var repos = this.repos;
	done = done || noop;
    return new Promise(function(resolve, reject) {
        repos.update(req, obj, where, function(err, data) {
            if (err) reject(err);
            else resolve(data);

            done(err, data);
        });
    });
}
Model.prototype.save = function save(req, obj, where, done) {
	var repos = this.repos;
	done = done || noop;
    return new Promise(function(resolve, reject) {
        repos.save(req, obj, where, function(err, data) {
            if (err) reject(err);
            else resolve(data);

            done(err, data);
        });
    });
}
Model.prototype.delete = function $delete(req, where, done) {
	var repos = this.repos;
	done = done || noop;
    return new Promise(function(resolve, reject) {
        repos.delete(req, where, function(err, data) {
            if (err) reject(err);
            else resolve(data);

            done(err, data);
        });
    });
}