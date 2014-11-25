'use strict';

describe('Controller: PatientStatusDfmCtrl', function () {

  // load the controller's module
  beforeEach(module('dentalPatientCardApp'));

  var PatientStatusDfmCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientStatusDfmCtrl = $controller('PatientStatusDfmCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
