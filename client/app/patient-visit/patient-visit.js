'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/visit', {
        templateUrl: 'app/patient-visit/patient-visit.html',
        controller: 'PatientVisitCtrl'
      });
  });
