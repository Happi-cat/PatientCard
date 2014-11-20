'use strict';

var express = require('express');
var controller = require('./patient-treatment-plan.controller');
var model = require('./../../components/express-model');
var permissions = require('./../../components/permissions');

var router = express.Router();

router.use(model('patientTreatmentPlan', require('./patient-treatment-plan.model')));

router.get('/', permissions.auth(), controller.index);
router.post('/', permissions.roles(['doctor', 'administrator']), controller.post);

module.exports = router;