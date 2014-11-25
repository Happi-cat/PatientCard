'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient-status-ohis', {
        templateUrl: 'app/patient-status-ohis/patient-status-ohis.html',
        controller: 'PatientStatusOhisCtrl'
      });
  });
