'use strict';

var _ = require('lodash');

module.exports.required = function required(value, options) {
	var message = options.message || "can't be blank";

	// Null and undefined aren't allowed
	if (_.isObject(value) && _.isEmpty(value)) {
		return message;
	}

	if (_.isString(value) && value.trim().length === 0) {
		return message;	
	}

	if (_.isNull(value) || _.isUndefined(value)) {
		return message;		
	}
}

module.exports.length = function length(value, options) {
	if (!value) {
		return;
	}

	var is = options.is;
	var maximum = options.maximum;
	var minimum = options.minimum;

	if (_.isNumber(is) && value.length !== is) {
		return options.wrongLength ||
		_.template("is the wrong length (should be ${count} characters)", {count: is}); 
	}

	if (_.isNumber(minimum) && value.length < minimum) {
		return options.tooShort ||
		_.template("is too short (minimum is ${count} characters)", {count: minimum});
	}

	if (_.isNumber(maximum) && value.length > maximum) {
		return options.tooLong ||
		_.template("is too long (maximum is ${count} characters)", {count: maximum});
	}
}
module.exports.number =  function number(value, options) {
	if (_.isNull(value) || _.isUndefined(value)) {
		return;
	}

	// If it's not a number we shouldn't continue since it will compare it.
	if (!_.isNumber(value)) {
		return options.message || "is not a number";
	}
}
module.exports.datetime = function datetime(value, options) {
	if (_.isNull(value) || _.isUndefined(value)) {
		return;
	}

	// If it's not a date we shouldn't continue since it will compare it.
	if (!_.isDate(value)) {
		return options.message || "is not a date";
	}
}

module.exports.format = function format(value, options) {
	if (_.isNull(value) || _.isUndefined(value)) {
		return;
	}

	if (_.isString(options) || (options instanceof RegExp)) {
		options = {pattern: options};
	}

	var message = options.message || "is invalid";
	var pattern = options.pattern;
	var match;

	if (!_.isString(value)) {
		return message;
	}

	if (_.isString(pattern)) {
		pattern = new RegExp(options.pattern, options.flags);
	}

	match = pattern.exec(value);
	if (!match || match[0].length !== value.length) {
		return message;
	}
}

module.exports.inclusion = function inclusion(value, options) {
	if (_.isNull(value) || _.isUndefined(value)) {
		return;
	}

	if (_.isArray(options)) {
		options = {within: options};
	}
	if (_.contains(options.within, value)) {
		return;
	}
	var message = options.message || "contains unsupported value %{value}";
	return _.template(message, {value: value});
}

module.exports.exclusion = function exclusion(value, options) {
	if (_.isNull(value) || _.isUndefined(value)) {
		return;
	}

	if (_.isArray(options)) {
		options = {within: options};
	}
	if (!_.contains(options.within, value)) {
		return;
	}
	var message = options.message || "contains restricted value %{value}";
	return _.template(message, {value: value});
}

module.exports.email = function email(value, options) {
	var message = options.message || "is not a valid email";
	if (_.isNull(value) || _.isUndefined(value)) {
		return;
	}
	if (!_.isString(value)) {
		return message;
	}
	if (!this.PATTERN.exec(value)) {
		return message;
	}

}

module.exports.email.PATTERN = /^[a-z0-9\u007F-\uffff!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9\u007F-\uffff!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z]{2,}$/i; 
