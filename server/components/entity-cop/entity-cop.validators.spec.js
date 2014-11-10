'use strict';

var _ = require('lodash');
var should = require('should');
var Cop = require('./entity-cop');

describe('Entity validators', function () {
	var t;

	describe('email validator', function () {
		var cop = new Cop({
			email: {
				validation:{
					email: true
				}
			}
		});

		it('should be valid', function () {
			t = ( _.isEmpty(cop.validate({ email : 'some_test@test.com' })) ).should.be.true;
		})

		it('should be invalid', function () {
			t = cop.validate({ email: 'invalida_email' }).should.be.ok;
		})
	})
})