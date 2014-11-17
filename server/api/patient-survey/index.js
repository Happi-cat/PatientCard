'use strict';

var express = require('express');
var controller = require('./patient-survey.controller');
var schema = require('./patient-survey.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientSurvey', schema));

router.get('/', controller.index);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;