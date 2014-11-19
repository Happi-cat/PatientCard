'use strict';

var express = require('express');
var controller = require('./patient.controller');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patient', require('./patient.model')));

router.get('/', controller.index);
router.get('/:patientId', controller.item);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;