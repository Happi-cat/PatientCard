'use strict';

var express = require('express');
var controller = require('./static-role.controller');
var schema = require('./static-role.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('role', schema));

router.get('/', controller.index);

module.exports = router;