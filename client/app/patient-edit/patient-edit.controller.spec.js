'use strict';

describe('Controller: PatientEditCtrl', function () {

  // load the controller's module
  beforeEach(module('dentalPatientCardApp'));

  var PatientEditCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientEditCtrl = $controller('PatientEditCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
