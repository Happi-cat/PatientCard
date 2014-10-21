'use strict';

angular.module('patientCardApp', [
  'ngCookies',
  'ngResource',
  'ngSanitize',
  'ngRoute',
  'ngResource',  
  'ui.bootstrap'
])
  .constant('ROLES', {
    admin: 'Administrator',
    doctor: 'Doctor',
    nurse: 'Nurse',
  })
  .config(function ($routeProvider, $locationProvider) {
    $routeProvider
      .otherwise({
        redirectTo: '/'
      });

    $locationProvider.html5Mode(true);
  });