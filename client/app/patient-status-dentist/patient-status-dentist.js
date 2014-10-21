'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient-status-dentist', {
        templateUrl: 'app/patient-status-dentist/patient-status-dentist.html',
        controller: 'PatientStatusDentistCtrl'
      });
  });
