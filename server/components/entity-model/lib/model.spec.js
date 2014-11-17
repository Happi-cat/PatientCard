'use strict';

var _ = require('lodash');
var should = require('should');
var Model = require('./model');

describe('Model', function() {
	var schema = {
		constraints: {
			a: {
				required: true,
			},
		},
		defaults: {
			b: 'Hello'
		},
		formulas: {
			c: function () {
				return 'computed'
			}
		}
	};

	it('should be valid', function () {
		var result = new Model({ a: 1 }, schema);

		result.defaults().calculate().validate();

		result.should.have.property('errors', null);
		result.should.have.property('schema', schema);
		result.should.have.property('value');

		result.value.should.have.property('a', 1);
		result.value.should.have.property('b', 'Hello');
		result.value.should.have.property('c', 'computed');
	});
});