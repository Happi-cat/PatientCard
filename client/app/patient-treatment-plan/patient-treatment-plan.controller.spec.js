'use strict';

describe('Controller: PatientTreatmentPlanCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientTreatmentPlanCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientTreatmentPlanCtrl = $controller('PatientTreatmentPlanCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
