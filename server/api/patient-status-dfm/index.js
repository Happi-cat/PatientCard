'use strict';

var express = require('express');
var controller = require('./patient-status-dfm.controller');
var schema = require('./patient-status-dfm.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientStatusDfm', schema));

router.get('/', controller.index);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;