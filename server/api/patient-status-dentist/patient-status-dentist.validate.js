'use strict';

var validate = require('validate');

var constraints = {
	patientId: {
		presence: true,
		numericality: true,
	},
};

exports = function (obj) {
	return validate(obj, constraints);
};