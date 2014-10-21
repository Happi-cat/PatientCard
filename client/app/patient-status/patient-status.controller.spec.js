'use strict';

describe('Controller: PatientStatusCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientStatusCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientStatusCtrl = $controller('PatientStatusCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
