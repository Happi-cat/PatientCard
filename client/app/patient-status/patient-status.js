'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/status', {
        templateUrl: 'app/patient-status/patient-status.html',
        controller: 'PatientStatusCtrl'
      });
  });
