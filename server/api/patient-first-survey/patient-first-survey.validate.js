'use strict';

var validate = require('validate');

var constraints = {
	patientId: {
		presence: true,
		numericality: true,
	},
	reason: {
		length: { maximum: 400 },
	},
	face: {
		length: { maximum: 400 },
	},
	skin: {
		length: { maximum: 400 },
	},
	limbs: {
		length: { maximum: 400 },
	},
	bones: {
		length: { maximum: 400 },
	},
};

var detailsConstraints = {
	patientId: {
		presence: true,
		numericality: true,
	},
	optionId: {
		presence: true,
		numericality: true,
	},
	details: {
		length: { maximum: 400 },
	}
}

exports = function (obj) {
	// TODO validate Subitems
	return validate(obj, constraints);
};