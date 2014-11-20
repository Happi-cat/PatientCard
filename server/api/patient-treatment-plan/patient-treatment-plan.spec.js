'use strict';

var should = require('should');
var app = require('../../app');
var request = require('supertest');

describe('GET /api/patient/:patientId/treatment-plan', function() {
  var patientId = 1;

  it('should respond with JSON Object', function(done) {
    request(app)
      .get('/api/patient/' + patientId + '/treatment-plan')
      .expect(200)
      .expect('Content-Type', /json/)
      .end(function(err, res) {
        if (err) return done(err);
        res.body.should.be.instanceof(Object);
        res.body.should.have.property('patientId', patientId);
        done();
      });
  });
});