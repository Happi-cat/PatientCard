'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/status', {
        templateUrl: 'app/patient-status/patient-status.html',
        controller: 'PatientStatusCtrl'
      });
  });
