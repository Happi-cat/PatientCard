'use strict';

var express = require('express');
var controller = require('./user.controller');
var auth = require('./../../auth/auth.service');

var router = express.Router();

router.get('/', auth.hasRole('administrator'), controller.index);
router.get('/me', auth.isAuthenticated(), controller.me);
router.get('/:username', auth.hasRole('administrator'),  controller.item);

module.exports = router;