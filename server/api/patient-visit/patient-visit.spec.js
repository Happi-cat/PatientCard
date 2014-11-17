'use strict';

var should = require('should');
var app = require('../../app');
var request = require('supertest');

describe('GET /api/patient/:patientId/visit', function() {
  var patientId = 1;

  it('should respond with JSON array', function(done) {
    request(app)
      .get('/api/patient/' + patientId + '/visit')
      .expect(200)
      .expect('Content-Type', /json/)
      .end(function(err, res) {
        if (err) return done(err);
        res.body.should.be.instanceof(Array);
        done();
      });
  });

  it('should respond on post with ok', function(done) {
    request(app)
      .post('/api/patient/' + patientId + '/visit')
      .send({ patientId : patientId })
      .expect(200) 
      .end(function(err, res) {
        if (err) return done(err);
        done();
      });
  });
});