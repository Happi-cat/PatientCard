'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/patient/:patientId/first-survey', {
        templateUrl: 'app/patient-first-survey/patient-first-survey.html',
        controller: 'PatientFirstSurveyCtrl'
      });
  });
