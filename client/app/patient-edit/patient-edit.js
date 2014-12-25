'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patients/:patientId/edit', {
        templateUrl: 'app/patient-edit/patient-edit.html',
        controller: 'PatientEditCtrl',
        auth: true,
      });
  });
