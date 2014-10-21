'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patients', {
        templateUrl: 'app/patient-list/patient-list.html',
        controller: 'PatientListCtrl'
      });
  });
