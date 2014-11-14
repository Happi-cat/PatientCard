'use strict';

var express = require('express');
var controller = require('./static-first-survey-option.controller');
var model = require('./static-first-survey-option.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('firstSurveyOption', model));

router.get('/', controller.index);

module.exports = router;