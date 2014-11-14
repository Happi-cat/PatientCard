'use strict';

var express = require('express');
var controller = require('./static-treatment-option.controller');
var model = require('./static-treatment-option.model');
var repo = require('./../../components/express-model');

var router = express.Router();

router.use(repo('treatmentOption', model));

router.get('/', controller.index);

module.exports = router;