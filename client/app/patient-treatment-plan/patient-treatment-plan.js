'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/treatment-plan', {
        templateUrl: 'app/patient-treatment-plan/patient-treatment-plan.html',
        controller: 'PatientTreatmentPlanCtrl'
      });
  });
