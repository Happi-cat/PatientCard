'use strict';

describe('Controller: PatientNewCtrl', function () {

  // load the controller's module
  beforeEach(module('dentalPatientCardApp'));

  var PatientNewCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientNewCtrl = $controller('PatientNewCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
