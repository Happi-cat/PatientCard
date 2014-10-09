'use strict';

angular.module('patient-card.directives').directive('myLanding', function () {
	return {
		restrict: 'A',
		scope: {
			landing: '=myLanding',
		},
		templateUrl: '/Widget/Landing',
	};
});