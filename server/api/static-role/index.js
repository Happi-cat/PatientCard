'use strict';

var express = require('express');
var controller = require('./static-role.controller');
var model = require('./static-role.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('role', model));

router.get('/', controller.index);

module.exports = router;