'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/new', {
        templateUrl: 'app/patient-new/patient-new.html',
        controller: 'PatientNewCtrl'
      });
  });
