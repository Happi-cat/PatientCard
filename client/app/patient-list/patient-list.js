'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patients', {
        templateUrl: 'app/patient-list/patient-list.html',
        controller: 'PatientListCtrl'
      });
  });
