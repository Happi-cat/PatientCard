'use strict';

var _ = require('lodash');
var should = require('should');
var Cop = require('./cop');

describe('Entity Cop (validator)', function() {
	var cop;
	var t;

	describe('constructor', function () {
		it('should be called successfully', function () {
			cop = new Cop(null);
			cop.should.be.an.instanceOf(Cop);

			cop = new Cop({ });
			cop.should.be.an.instanceOf(Cop);

			cop = new Cop({
				prop: {
					validation: {
						required: true,
					},
				},
				noValidation: true,
			});

			cop.constraints.should.have.property('prop', { required: true });
			cop.constraints.should.not.have.property('noValidation');
		});
	});

	describe('validate', function () {
		it('should be valid if there are no constraints', function () {
			cop = new Cop({});

			t = _.isEmpty( cop.validate(null) ).should.be.true;
			t = _.isEmpty( cop.validate({}) ).should.be.true;
			t = _.isEmpty( cop.validate({ someField: 'someValue' }) ).should.be.true;
		});

		it('should throw error if invalid or unkown validator', function () {
			cop = new Cop({
				prop: {
					validation: {
						undefinedValidator: true,
					},
				},
			});

			cop.constraints.should.have.property('prop', { undefinedValidator: true });

			var f = function () {
				cop.validate({});
			};
			
			f.should.throw();
		});

		it('should validate for required (as an example)', function () {
			cop = new Cop({
				prop: {
					validation: {
						required: true,
					},
				},
			});

			cop.constraints.should.have.property('prop', { required: true });

			// not valid instance
			cop.validate({}).should.have.property('prop'); 
			cop.validate({ prop: null }).should.have.property('prop'); 
			cop.validate({ prop: '  ' }).should.have.property('prop'); 
			cop.validate({ prop: {} }).should.have.property('prop'); 
			cop.validate({ prop: [] }).should.have.property('prop'); 
			
			// valid instance
			t = _.isEmpty( cop.validate({ prop: true }) ).should.be.true; 
			t = _.isEmpty( cop.validate({ prop: ' aasd ' }) ).should.be.true; 
			t = _.isEmpty( cop.validate({ prop: 1 }) ).should.be.true; 
			t = _.isEmpty( cop.validate({ prop: { a : 1 } }) ).should.be.true; 
			t = _.isEmpty( cop.validate({ prop: [ 1 ] }) ).should.be.true; 
			t = _.isEmpty( cop.validate({ prop: true }) ).should.be.true; 
			t = _.isEmpty( cop.validate({ prop: false }) ).should.be.true; 
		});
});

describe('validators', function () {
	it('required with calculated options', function () {
		cop = new Cop({ 
			prop: {
				validation: {
					required: function () { return this.number === true; },
				},
			},
		});

		cop.validate({  number: true }).should.have.property('prop');
		t = _.isEmpty( cop.validate({  }) ).should.be.true;
		t = _.isEmpty( cop.validate({ prop: true, number: true  }) ).should.be.true;
	});
});
});
