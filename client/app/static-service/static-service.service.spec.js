'use strict';

describe('Service: staticService', function () {

  // load the service's module
  beforeEach(module('patientCardApp'));

  // instantiate service
  var staticService;
  beforeEach(inject(function (_staticService_) {
    staticService = _staticService_;
  }));

  it('should do something', function () {
    expect(!!staticService).toBe(true);
  });

});
