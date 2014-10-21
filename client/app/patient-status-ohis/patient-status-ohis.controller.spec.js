'use strict';

describe('Controller: PatientStatusOhisCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientStatusOhisCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientStatusOhisCtrl = $controller('PatientStatusOhisCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
