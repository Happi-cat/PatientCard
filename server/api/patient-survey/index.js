'use strict';

var express = require('express');
var controller = require('./patient-survey.controller');
var schema = require('./patient-survey.model');
var model = require('./../../components/express-model');
var permissions = require('./../../components/permissions');

var router = express.Router();

router.use(model('patientSurvey', schema));

router.get('/', permissions.auth(), controller.index);
router.post('/', permissions.roles(['doctor', 'administrator']), controller.post);
router.put('/', permissions.roles(['doctor', 'administrator']), controller.put);

module.exports = router;