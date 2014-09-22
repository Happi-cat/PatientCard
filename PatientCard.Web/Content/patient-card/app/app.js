'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'ui.bootstrap', 'nvd3ChartDirectives', 'ngRoute'])
	.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
		$routeProvider
			.when('/', { templateUrl: '/Page/Home', controller: LandingCtrl })
			.when('/patients', { templateUrl: '/Page/Patients' })
			.when('/patient', { templateUrl: '/Page/Patient' })
			.when('/help', { templateUrl: '/Page/Help' })
			.when('/about', { templateUrl: '/Page/About' })
			.otherwise({ redirectTo: '/' });

		// NOTE: This part is very important
		$locationProvider.html5Mode(false).hashPrefix('!');
	}]
	).run(function ($rootScope, $timeout) {
		$rootScope.alerts = [];

		$rootScope.addAlert = function (alert) {
			$rootScope.alerts.push(alert);
			$timeout(function () {
				$rootScope.alerts.splice($rootScope.alerts.indexOf(alert), 1);
			}, 3 * 60 * 1000);
		};

		$rootScope.closeAlert = function (index) {
			$rootScope.alerts.splice(index, 1);
		};
	});