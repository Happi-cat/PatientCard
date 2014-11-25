'use strict';

var express = require('express');
var controller = require('./patient-status-cpi.controller');
var auth = require('./../../auth/auth.service');

var router = express.Router();

router.get('/', auth.isAuthenticated(), controller.index);
router.post('/', auth.hasRole(['doctor', 'administrator']), controller.create);
router.put('/', auth.hasRole(['doctor', 'administrator']), controller.update);

module.exports = router;