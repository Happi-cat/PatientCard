'use strict';

var express = require('express');
var controller = require('./patient-status-ohis.controller');
var model = require('./patient-status-ohis.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientStatusOhis', model));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;