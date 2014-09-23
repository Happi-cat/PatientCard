'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'ui.bootstrap', 'nvd3ChartDirectives', 'ngRoute'])
	.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
		$routeProvider
			.when('/', { templateUrl: '/Page/Home' })
			.when('/patients', { templateUrl: '/Page/Patients' })
			.when('/patient/view/:id', { templateUrl: '/Page/Patient' })
			.when('/patient/new', { templateUrl: '/Page/Patient' })
			.when('/patient/edit/:id', { templateUrl: '/Page/Patient' })
			.when('/help', { templateUrl: '/Page/Help' })
			.when('/about', { templateUrl: '/Page/About' })
			.otherwise({ redirectTo: '/' });

		// NOTE: This part is very important
		$locationProvider.html5Mode(false).hashPrefix('!');
	}]
	).run(function ($rootScope, $timeout) {
		$rootScope.actions = [];

		$rootScope.registerLink = function (action) {
			$rootScope.actions.push(action);
		};

	});