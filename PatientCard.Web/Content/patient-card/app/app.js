'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'ui.bootstrap', 'ui.router', 'nvd3ChartDirectives', 'ngRoute'])
	.config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider) {
		$routeProvider
			.when('/', { templateUrl: '/Page/Home', controller: 'LandingCtrl' })
			.when('/patients', { templateUrl: '/Page/Patients' })
			.when('/patient/view/:id', { templateUrl: '/Patient/Overview', controller: 'PatientCtrl' })
			.when('/patient/view/:id/first-survey', { templateUrl: '/Patient/FirstSurvey', controller: 'PatientCtrl' })
			.when('/patient/view/:id/survey', { templateUrl: '/Patient/Survey', controller: 'PatientCtrl' })
			.when('/patient/view/:id/threatment-plan', { templateUrl: '/Patient/ThreatmentPlan', controller: 'PatientCtrl' })
			.when('/patient/view/:id/visit-diary', { templateUrl: '/Patient/VisitDiary', controller: 'PatientCtrl' })
			.when('/patient/new', { templateUrl: '/Patient/Editor' })
			.when('/patient/edit/:id', { templateUrl: '/Patient/Editor', controller: 'PatientCtrl' })
			.when('/patient/edit/:id/threatment-plan', { templateUrl: '/Patient/ThreatmentPlanEditor', controller: 'PatientCtrl' })
			.when('/help', { templateUrl: '/Page/Help' })
			.when('/about', { templateUrl: '/Page/About' })
			.otherwise({ redirectTo: '/' });

		// NOTE: This part is very important
		$locationProvider.html5Mode(false).hashPrefix('!');
	}]
	).run(function($rootScope, $timeout) {
		$rootScope.alerts = [];

		$rootScope.addAlert = function (alert) {
			$rootScope.alerts.push(alert);
		};

		$rootScope.closeAlert = function (index) {
			$scope.alerts.splice(index, 1);
		};

	});