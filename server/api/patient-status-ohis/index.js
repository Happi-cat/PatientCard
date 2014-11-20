'use strict';

var express = require('express');
var controller = require('./patient-status-ohis.controller');
var schema = require('./patient-status-ohis.model');
var model = require('./../../components/express-model');
var permissions = require('./../../components/permissions');

var router = express.Router();

router.use(model('patientStatusOhis', schema));

router.get('/', permissions.auth(), controller.index);
router.post('/', permissions.roles(['doctor', 'administrator']), controller.post);
router.put('/', permissions.roles(['doctor', 'administrator']), controller.put);

module.exports = router;