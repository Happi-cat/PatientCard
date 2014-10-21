'use strict';

var express = require('express');
var controller = require('./patient-survey.controller');

var router = express.Router();

router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;