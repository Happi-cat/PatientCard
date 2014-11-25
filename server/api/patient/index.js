'use strict';

var express = require('express');
var controller = require('./patient.controller');
var auth = require('./../../auth/auth.service');

var router = express.Router();

router.get('/', auth.isAuthenticated(), controller.index);
router.get('/:patientId', auth.isAuthenticated(), controller.item);
router.post('/', auth.hasRole(['nurse', 'doctor', 'administrator']), controller.create);
router.put('/', auth.hasRole(['nurse', 'doctor', 'administrator']), controller.update);

module.exports = router;