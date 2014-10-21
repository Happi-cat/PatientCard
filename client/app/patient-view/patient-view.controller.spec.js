'use strict';

describe('Controller: PatientViewCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientViewCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientViewCtrl = $controller('PatientViewCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
