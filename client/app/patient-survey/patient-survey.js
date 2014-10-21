'use strict';

angular.module('patientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/survey', {
        templateUrl: 'app/patient-survey/patient-survey.html',
        controller: 'PatientSurveyCtrl'
      });
  });
