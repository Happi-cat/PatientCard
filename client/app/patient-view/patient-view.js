'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/view', {
        templateUrl: 'app/patient-view/patient-view.html',
        controller: 'PatientViewCtrl'
      });
  });
