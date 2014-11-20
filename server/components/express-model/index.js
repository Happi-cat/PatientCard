'use strict';

var _ = require('lodash');
var Promise = require('es6-promise').Promise; // jshint ignore:line

var noop = function() {};

module.exports = function(name, schema) {
    var model = require('./../entity-model')(schema);
    var db = model.db;

    return function(req, res, next) {
        req.models = req.models || {};

        req.models[name] = model;

        model.find = function(where, done) {
            done = done || noop;
            return new Promise(function(resolve, reject) {
                db.find(req, where, function(err, data) {
                    if (err) reject(err);
                    else resolve(data);

                    done(err, data);
                });
            });
        };
        model.findOne = function(where, done) {
            done = done || noop;
            return new Promise(function(resolve, reject) {
                db.findOne(req, where, function(err, data) {
                    if (err) reject(err);
                    else resolve(data);

                    done(err, data);
                });
            });
        };
        model.create = function(obj, done) {
            done = done || noop;
            return new Promise(function(resolve, reject) {
                db.create(req, obj, function(err, data) {
                    if (err) reject(err);
                    else resolve(data);

                    done(err, data);
                });
            });
        };
        model.update = function(obj, where, done) {
            done = done || noop;
            return new Promise(function(resolve, reject) {
                db.update(req, obj, where, function(err, data) {
                    if (err) reject(err);
                    else resolve(data);

                    done(err, data);
                });
            });
        };
        model.save = function(obj, where, done) {
            done = done || noop;
            return new Promise(function(resolve, reject) {
                db.save(req, obj, where, function(err, data) {
                    if (err) reject(err);
                    else resolve(data);

                    done(err, data);
                });
            });
        };
        model.delete = function(where, done) {
            done = done || noop;
            return new Promise(function(resolve, reject) {
                db.delete(req, where, function(err, data) {
                    if (err) reject(err);
                    else resolve(data);

                    done(err, data);
                });
            });
        };

        next();
    };
}