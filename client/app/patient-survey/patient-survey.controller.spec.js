'use strict';

describe('Controller: PatientSurveyCtrl', function () {

  // load the controller's module
  beforeEach(module('patientCardApp'));

  var PatientSurveyCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientSurveyCtrl = $controller('PatientSurveyCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
