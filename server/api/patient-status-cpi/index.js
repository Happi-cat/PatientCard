'use strict';

var express = require('express');
var controller = require('./patient-status-cpi.controller');
var schema = require('./patient-status-cpi.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientStatusCpi', schema));


router.get('/', controller.index);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;