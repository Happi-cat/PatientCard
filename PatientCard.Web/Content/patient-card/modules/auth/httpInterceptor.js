'use strict';

angular.module('patient-card.auth')
	.factory('authHttpInterceptor', function($q, $location, URLS) {
		return {
			'responseError': function(rejection) {
				if (rejection.status == 401 ||
					rejection.status == 403) {
					$location.path(URLS.login);
				}
				return $q.reject(rejection);
			}
		};
	});