'use strict';

describe('Controller: PatientVisitCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientVisitCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientVisitCtrl = $controller('PatientVisitCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
