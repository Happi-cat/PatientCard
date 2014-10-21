'use strict';

var express = require('express');
var controller = require('./patient-status-cpi.controller');

var router = express.Router();

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;