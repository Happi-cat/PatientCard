'use strict';

var express = require('express');
var controller = require('./patient-first-survey.controller');
var model = require('./patient-first-survey.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientFirstSurvey', model));
router.use(repo('patientFirstSurveyDetails', model.details));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;