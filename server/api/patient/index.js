'use strict';

var express = require('express');
var controller = require('./patient.controller');

var router = express.Router();

router.get('/', controller.index);
router.get('/:patientId', controller.item);
router.post('/', controller.post);

module.exports = router;