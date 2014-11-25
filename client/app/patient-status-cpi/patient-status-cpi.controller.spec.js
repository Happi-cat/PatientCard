'use strict';

describe('Controller: PatientStatusCpiCtrl', function () {

  // load the controller's module
  beforeEach(module('dentalPatientCardApp'));

  var PatientStatusCpiCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientStatusCpiCtrl = $controller('PatientStatusCpiCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
