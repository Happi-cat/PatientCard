'use strict';

var express = require('express');
var controller = require('./static-first-survey-option.controller');
var schema = require('./static-first-survey-option.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('firstSurveyOption', schema));

router.get('/', controller.index);

module.exports = router;