'use strict';

var express = require('express');
var controller = require('./static-survey-type.controller');

var router = express.Router();

router.get('/', controller.index);

module.exports = router;