'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient-status-dfm', {
        templateUrl: 'app/patient-status-dfm/patient-status-dfm.html',
        controller: 'PatientStatusDfmCtrl'
      });
  });
