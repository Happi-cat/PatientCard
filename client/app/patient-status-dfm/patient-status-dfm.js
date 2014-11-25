'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient-status-dfm', {
        templateUrl: 'app/patient-status-dfm/patient-status-dfm.html',
        controller: 'PatientStatusDfmCtrl'
      });
  });
