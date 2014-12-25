'use strict';

angular.module('dentalPatientCardApp')
  .directive('landing', function () {
    return {
      templateUrl: 'components/landing/landing.html',
      scope: {
      	datasource: '=',
      },
      restrict: 'EA',
    };
  });