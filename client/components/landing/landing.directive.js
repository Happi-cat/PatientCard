'use strict';

angular.module('patientCardApp')
  .directive('landing', function () {
    return {
      templateUrl: 'components/landing/landing.html',
      scope: {
      	datasource: '=',
      },
      restrict: 'EA',
    };
  });