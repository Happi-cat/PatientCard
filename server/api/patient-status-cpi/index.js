'use strict';

var express = require('express');
var controller = require('./patient-status-cpi.controller');
var model = require('./patient-status-cpi.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientStatusCpi', model));


router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;