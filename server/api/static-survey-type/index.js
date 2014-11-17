'use strict';

var express = require('express');
var controller = require('./static-survey-type.controller');
var schema = require('./static-survey-type.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('surveyType', schema));

router.get('/', controller.index);

module.exports = router;