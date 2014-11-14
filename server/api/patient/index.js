'use strict';

var express = require('express');
var controller = require('./patient.controller');
var model = require('./patient.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patient', model));

router.get('/', controller.index);
router.get('/:patientId', controller.item);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;