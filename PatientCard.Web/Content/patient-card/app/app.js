'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'ui.bootstrap', 'nvd3ChartDirectives', 'ngRoute'])
	.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
		$routeProvider
			//.when('/', { templateUrl: '/Page/Overview', controller: OverviewCtrl })
			//.when('/packages', { templateUrl: '/Page/Packages', controller: PackagesPageCtrl })
			//.when('/currencies', { templateUrl: '/Page/Currencies', controller: CurrenciesPageCtrl })
			//.when('/weather', { templateUrl: '/Page/Weather', controller: WeatherPageCtrl })
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