'use strict';

angular.module('dentalPatientCardApp', [
  'ngCookies',
  'ngResource',
  'ngSanitize',
  'ngRoute',
  'ngResource',  
  'ngAnimate',
  'ui.bootstrap'
])
  .constant('ROLES', {
    admin: 'administrator',
    doctor: 'doctor',
    nurse: 'nurse',
  })
  .config(function ($routeProvider, $locationProvider) {
    $routeProvider
      .otherwise({
        redirectTo: '/'
      });

    $locationProvider.html5Mode(true);
  });