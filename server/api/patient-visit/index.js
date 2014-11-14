'use strict';

var express = require('express');
var controller = require('./patient-visit.controller');
var model = require('./patient-visit.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('patientVisit', model));


router.get('/', controller.index);
router.post('/', controller.post);

module.exports = router;