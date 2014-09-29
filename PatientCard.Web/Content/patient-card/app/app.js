'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'ui.bootstrap', 'ui.router', 'nvd3ChartDirectives', 'ngRoute'])
	.config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider) {
		$routeProvider
			.when('/', { templateUrl: '/Page/Home', controller: 'LandingCtrl' })
			.when('/login', { templateUrl: '/Page/Login', controller: 'LandingCtrl' })
			.when('/patients', { templateUrl: '/Page/Patients' })
			.when('/patient/view/:id', { templateUrl: '/Patient/Overview', controller: 'PatientCtrl' })
			.when('/patient/view/:id/first-survey', { templateUrl: '/Patient/FirstSurvey', controller: 'PatientCtrl' })
			.when('/patient/view/:id/survey', { templateUrl: '/Patient/Survey', controller: 'PatientCtrl' })
			.when('/patient/view/:id/threatment-plan', { templateUrl: '/Patient/ThreatmentPlan', controller: 'PatientCtrl' })
			.when('/patient/view/:id/visit-diary', { templateUrl: '/Patient/VisitDiary', controller: 'PatientCtrl' })
			.when('/patient/new', { templateUrl: '/Patient/Editor', controller: 'PatientNewCtrl' })
			.when('/patient/edit/:id', { templateUrl: '/Patient/Editor', controller: 'PatientEditCtrl' })
			.when('/patient/edit/:id/threatment-plan', { templateUrl: '/Patient/ThreatmentPlanEditor', controller: 'PatientCtrl' })
			.when('/help', { templateUrl: '/Page/Help' })
			.when('/about', { templateUrl: '/Page/About' })
			.otherwise({ redirectTo: '/' });

		// NOTE: This part is very important
		$locationProvider.html5Mode(false).hashPrefix('!');
	}]
	).run(function($rootScope, $location, $timeout) {
		$rootScope.alerts = [];

		$timeout(function() {
			
				$rootScope.alerts.splice(0, 1);
		}, 30000);

		$rootScope.addAlert = function (alert) {
			if ($rootScope.alerts.length > 3) {
				$rootScope.alerts.splice(0, 1);
			}
			$rootScope.alerts.push(alert);
		};

		$rootScope.closeAlert = function (index) {
			$rootScope.alerts.splice(index, 1);
		};

		$rootScope.onLoadFailed = function (error) {
			console.log(error);
			$rootScope.addAlert({ type: 'danger', title: 'Ошибка при загрузке', details: 'Не удаётся загрузить данные' });
		};

		$rootScope.onSaveFailed = function(error) {
			console.log(error);
			$rootScope.addAlert({ type: 'danger', title: 'Ошибка при сохранении', details: 'Не удаётся сохранить данные' });
		};

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