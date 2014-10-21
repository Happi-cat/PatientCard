'use strict';

describe('Controller: PatientListCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientListCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientListCtrl = $controller('PatientListCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
