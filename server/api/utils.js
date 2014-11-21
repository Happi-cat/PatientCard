'use strict';

module.exports.validationError = function(res, errors) {
	return res.status(422).json(errors);
}

module.exports.ok = function (res) {
	return res.status(200).json(true);
}

module.exports.created = function(res) {
	return res.status(201).json(true);
}