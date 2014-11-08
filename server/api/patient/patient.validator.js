'use strict';

var validate = require('validate');

var constraints = {
	firstName: { 
		presence: true,
		//length: { maximum: 100 },
	},
	lastName: { 
		presence: true,
		//length: { maximum: 100 },
	},
	middleName: { 
		presence: true,
		//length: { maximum: 100 },
	},
	birthDate: {
		presence: true,
		datetime: true,
	},
	gender: {
		presence: true,
		inclusion: ['male', 'female'],
	},
	address: {
		presence: true,
		//length: { maximum: 400 },
	},
	phone: {
		//length: { maximum: 400 },
	},
	socialStatus: {
		//length: { maximum: 400 },
	},
	job: {
		//length: { maximum: 400 },
	},
};

module.exports = function (obj) {
	return validate(obj, constraints);
};