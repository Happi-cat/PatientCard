'use strict';

var should = require('should');
var mapper = require('./mapper');
var request = require('supertest');


describe('Entity Mapper', function() {
  var fields = {
    "old_field": "new_field",
    "insertable": {
      prop: "insertable",
      insertable: true,
    },
    "updatable": {
      prop: "updatable",
      updatable: true
    },
  };

  it('should generate map', function(done) {
    var map = mapper.buildMap(fields);
    map.should.have.property("select");
    map.should.have.property("insert");
    map.should.have.property("update");
    map.should.have.property("filter");

    map.select.should.have.property("old_field", "new_field");
    map.select.should.have.property("insertable", "insertable");
    map.select.should.have.property("updatable", "updatable");
    map.select.should.not.have.property("new_field");

    map.filter.should.have.property("new_field", "old_field");
    map.filter.should.have.property("insertable", "insertable");
    map.filter.should.have.property("updatable", "updatable");
    map.filter.should.not.have.property("old_field");

    map.insert.should.have.property("new_field", "old_field");
    map.insert.should.have.property("insertable", "insertable");
    map.insert.should.not.have.property("updatable");
    map.insert.should.not.have.property("old_field");

    map.update.should.have.property("new_field", "old_field");
    map.update.should.not.have.property("insertable");
    map.update.should.have.property("updatable", "updatable");
    map.update.should.not.have.property("old_field");

    done();
  });

  it('should convert object', function (done) {
    var map = { 
      'old' : 'new'
    };

    var res = mapper.convert({ 
      'old': 1,
      'a' : 2
    }, map);

    res.should.have.property('new', 1);
    res.should.not.have.property('old');
    res.should.not.have.property('a');

    done();
  });

  it('should convert array', function (done) {
    var map = { 
      'old' : 'new',
      'two': 'one',
    };

    var res = mapper.convert([{ 
      'old': 1,
      'two': 2,
      'a' : 2
    }], map);

    res.should.be.an.Array.and.have.length(1);

    res[0].should.containEql({ 'new': 1 });
    res[0].should.containEql({ 'one': 2 });

    res[0].should.not.have.property('old');
    res[0].should.not.have.property('two');
    res[0].should.not.have.property('a');

    done();
  })
});