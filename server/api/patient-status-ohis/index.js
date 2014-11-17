'use strict';

var express = require('express');
var controller = require('./patient-status-ohis.controller');
var schema = require('./patient-status-ohis.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientStatusOhis', schema));

router.get('/', controller.index);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;