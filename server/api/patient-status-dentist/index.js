'use strict';

var express = require('express');
var controller = require('./patient-status-dentist.controller');
var model = require('./patient-status-dentist.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientStatusDentist', model));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;