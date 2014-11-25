'use strict';

describe('Controller: PatientFirstSurveyCtrl', function () {

  // load the controller's module
  beforeEach(module('dentalPatientCardApp'));

  var PatientFirstSurveyCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PatientFirstSurveyCtrl = $controller('PatientFirstSurveyCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
