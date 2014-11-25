'use strict';

angular.module('dentalPatientCardApp')
  .config(function ($routeProvider) {
    $routeProvider
      .when('/help', {
        templateUrl: 'app/help/help.html',
        controller: 'HelpCtrl'
      });
  });
