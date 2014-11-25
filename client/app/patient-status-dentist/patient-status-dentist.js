'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient-status-dentist', {
        templateUrl: 'app/patient-status-dentist/patient-status-dentist.html',
        controller: 'PatientStatusDentistCtrl'
      });
  });
