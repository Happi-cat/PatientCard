'use strict';

var express = require('express');
var controller = require('./static-treatment-option.controller');
var schema = require('./static-treatment-option.model');
var model = require('./../../components/express-model');

var router = express.Router();

router.use(model('treatmentOption', schema));

router.get('/', controller.index);

module.exports = router;