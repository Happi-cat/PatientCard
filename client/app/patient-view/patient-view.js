'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/view', {
        templateUrl: 'app/patient-view/patient-view.html',
        controller: 'PatientViewCtrl'
      });
  });
