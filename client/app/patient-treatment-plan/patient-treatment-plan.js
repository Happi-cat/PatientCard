'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/treatment-plan', {
        templateUrl: 'app/patient-treatment-plan/patient-treatment-plan.html',
        controller: 'PatientTreatmentPlanCtrl'
      });
  });
