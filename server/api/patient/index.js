'use strict';

var express = require('express');
var controller = require('./patient.controller');
var model = require('./../../components/express-model');
var permissions = require('./../../components/permissions');

var router = express.Router();

router.use(model('patient', require('./patient.model')));

router.get('/', permissions.auth(), controller.index);
router.get('/:patientId', permissions.auth(), controller.item);
router.post('/', permissions.roles(['nurse', 'doctor', 'administrator']), controller.post);
router.put('/', permissions.roles(['nurse', 'doctor', 'administrator']), controller.put);

module.exports = router;