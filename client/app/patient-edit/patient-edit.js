'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/edit', {
        templateUrl: 'app/patient-edit/patient-edit.html',
        controller: 'PatientEditCtrl'
      });
  });
