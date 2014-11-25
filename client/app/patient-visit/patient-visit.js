'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/visit', {
        templateUrl: 'app/patient-visit/patient-visit.html',
        controller: 'PatientVisitCtrl'
      });
  });
