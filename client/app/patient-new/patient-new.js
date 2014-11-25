'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/new', {
        templateUrl: 'app/patient-new/patient-new.html',
        controller: 'PatientNewCtrl'
      });
  });
