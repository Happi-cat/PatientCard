'use strict';

var _ = require('lodash');

module.exports = function calculate(obj, formulas) {
	obj = obj || {};

	for(var prop in formulas) {
		var formula = formulas[prop];
		var value = obj[prop];

		if (_.isFunction(formula)) {
			obj[prop] = formula.call(obj, value, prop);
		} else {
			obj[prop] = formula;
		}
	}

	return obj;
}