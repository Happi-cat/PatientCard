'use strict';

var express = require('express');
var controller = require('./patient-treatment-plan.controller');
var schema = require('./patient-treatment-plan.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientTreatmentPlan', schema));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;