'use strict';

angular.module('patientCardApp')
  .directive('breadcrumb', function () {
    return {
		restrict: 'EA',
		scope: {
			datasource: '=',
		},
		templateUrl: 'components/breadcrumb/breadcrumb.html',
	};
  });