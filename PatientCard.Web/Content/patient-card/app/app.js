'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'ui.bootstrap', 'ui.router', 'nvd3ChartDirectives', 'ngRoute'])
	.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
		$routeProvider
			.when('/', { templateUrl: '/Page/Home' })
			.when('/patients', { templateUrl: '/Page/Patients' })
			.when('/patient/view/:id', { templateUrl: '/Page/PatientOverview' })
			.when('/patient/view/:id/first-survey', { templateUrl: '/Page/PatientFirstSurvey' })
			.when('/patient/view/:id/survey', { templateUrl: '/Page/PatientSurvey' })
			.when('/patient/view/:id/threatment-plan', { templateUrl: '/Page/PatientThreatmentPlan' })
			.when('/patient/view/:id/visit-diary', { templateUrl: '/Page/PatientVisitDiary' })
			.when('/patient/new', { templateUrl: '/Page/PatientEditor' })
			.when('/patient/edit/:id', { templateUrl: '/Page/PatientEditor' })
			.when('/patient/edit/:id/threatment-plan', { templateUrl: '/Page/PatientThreatmentPlanEditor' })
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