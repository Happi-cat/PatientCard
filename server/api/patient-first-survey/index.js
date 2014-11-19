'use strict';

var express = require('express');
var controller = require('./patient-first-survey.controller');
var schema = require('./patient-first-survey.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientFirstSurvey', schema));
router.use(model('patientFirstSurveyDetails', schema.details));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;