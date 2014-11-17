'use strict';

var _ = require('lodash');
var should = require('should');
var defaults = require('./defaults');

describe('Cop. Defaults', function() {
	var defaultValues = {
		a: 0,
		b: 1,
		c: null,
	};

	it('should set default values', function () {
		var result = defaults({ d: '' }, defaultValues);

		result.should.have.property('a', 0);
		result.should.have.property('b', 1);
		result.should.have.property('c', null);
		result.should.have.property('d', '');
	});
});