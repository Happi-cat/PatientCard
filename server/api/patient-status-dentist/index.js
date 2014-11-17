'use strict';

var express = require('express');
var controller = require('./patient-status-dentist.controller');
var schema = require('./patient-status-dentist.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientStatusDentist', schema));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;