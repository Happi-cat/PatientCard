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