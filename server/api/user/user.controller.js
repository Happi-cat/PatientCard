'use strict';

var _ = require('lodash');
var utils = require('./../utils');
var User =  require('./user.model');

// Get list of users
exports.index = function(req, res) {
  res.json([]);
};