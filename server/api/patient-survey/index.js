'use strict';

var express = require('express');
var controller = require('./patient-survey.controller');
var model = require('./patient-survey.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientSurvey', model));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;