'use strict';

var express = require('express');
var controller = require('./static-survey-type.controller');
var model = require('./static-survey-type.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('surveyType', model));

router.get('/', controller.index);

module.exports = router;