'use strict';

angular.module('patient-card.directives').directive('myBreadcrumb', function () {
	return {
		restrict: 'A',
		scope: {
			breadcrumb: '=myBreadcrumb',
		},
		templateUrl: '/Widget/Breadcrumb',
	};
});