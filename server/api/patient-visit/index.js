'use strict';

var express = require('express');
var controller = require('./patient-visit.controller');
var schema = require('./patient-visit.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('patientVisit', schema));


router.get('/', controller.index);
router.post('/', controller.post);
router.put('/', controller.put);

module.exports = router;