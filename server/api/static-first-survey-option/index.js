'use strict';

var express = require('express');
var controller = require('./static-first-survey-option.controller');

var router = express.Router();

router.get('/', controller.index);

module.exports = router;