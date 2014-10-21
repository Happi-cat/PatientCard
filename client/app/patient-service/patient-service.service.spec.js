'use strict';

describe('Service: patientService', function () {

  // load the service's module
  beforeEach(module('patientCardApp'));

  // instantiate service
  var patientService;
  beforeEach(inject(function (_patientService_) {
    patientService = _patientService_;
  }));

  it('should do something', function () {
    expect(!!patientService).toBe(true);
  });

});
