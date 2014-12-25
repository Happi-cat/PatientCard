'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patients/new', {
        templateUrl: 'app/patient-new/patient-new.html',
        controller: 'PatientNewCtrl',
        auth: true,
      });
  });
