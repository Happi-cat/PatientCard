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
  })
  .run(function ($rootScope, $location) {
    $rootScope.goUp = function (breadcrumb) {
      if (breadcrumb && breadcrumb.items) {
        var items = breadcrumb.items;
        if (items.length > 0) {
          var prev = items[items.length - 1];
          if (prev.url) {
            $location.path(prev.url);
          }
        }
      }
    };
  });