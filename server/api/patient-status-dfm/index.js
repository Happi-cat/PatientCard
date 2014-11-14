'use strict';

var express = require('express');
var controller = require('./patient-status-dfm.controller');
var model = require('./patient-status-dfm.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientStatusDfm', model));

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;