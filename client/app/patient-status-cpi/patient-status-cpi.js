'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient-status-cpi', {
        templateUrl: 'app/patient-status-cpi/patient-status-cpi.html',
        controller: 'PatientStatusCpiCtrl'
      });
  });
