'use strict';

var express = require('express');
var controller = require('./patient-visit.controller');
var schema = require('./patient-visit.model');
var model = require('./../../components/express-model');
var permissions = require('./../../components/permissions');

var router = express.Router();

router.use(model('patientVisit', schema));


router.get('/', permissions.auth(), controller.index);
router.post('/', permissions.roles(['doctor', 'administrator']), controller.post);
router.put('/', permissions.roles(['doctor', 'administrator']), controller.put);

module.exports = router;