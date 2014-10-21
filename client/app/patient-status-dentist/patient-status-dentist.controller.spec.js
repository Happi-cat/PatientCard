'use strict';

describe('Controller: PatientStatusDentistCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientStatusDentistCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientStatusDentistCtrl = $controller('PatientStatusDentistCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
