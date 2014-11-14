'use strict';

var express = require('express');
var controller = require('./patient-treatment-plan.controller');
var model = require('./patient-treatment-plan.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientTreatmentPlan', model));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;