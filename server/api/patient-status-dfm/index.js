'use strict';

var express = require('express');
var controller = require('./patient-status-dfm.controller');
var schema = require('./patient-status-dfm.model');
var model = require('./../../components/express-model');
var permissions = require('./../../components/permissions');

var router = express.Router();

router.use(model('patientStatusDfm', schema));

router.get('/', permissions.auth(), controller.index);
router.post('/', permissions.roles(['doctor', 'administrator']), controller.post);
router.put('/', permissions.roles(['doctor', 'administrator']), controller.put);

module.exports = router;