'use strict';

var _ = require('lodash');
var should = require('should');
var calculate = require('./calculate');

describe('Cop. Calculate', function() {
	var formulas = {
		calculated1: function () {
			return 1;
		},
		calculated2: 2,
		calculated3: function () {
			return this.a + 3;
		},
	};

	it('should calculate formulas', function () {
		var result = calculate({ a: 1, b: 2, c: 3 }, formulas);

		result.should.have.property('a', 1);
		result.should.have.property('b', 2);
		result.should.have.property('c', 3);
		result.should.have.property('calculated1', 1);
		result.should.not.have.property('calculated2');
		result.should.have.property('calculated3', 4);
	});
});