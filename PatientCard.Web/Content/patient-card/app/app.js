'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'patient-card.auth', 'ui.bootstrap', 'ui.router', 'nvd3ChartDirectives', 'ngRoute'])
	.constant('URLS', {
		login: '/login',
		home: '/',
		logout: '/logout',
	})
	.config(['$routeProvider', '$locationProvider', '$httpProvider', function($routeProvider, $locationProvider, $httpProvider) {
		$routeProvider
			.when('/', {
				templateUrl: '/Page/Home',
				controller: 'LandingCtrl',
				perm: { authorized: true }
			})
			.when('/login', {
				templateUrl: '/Page/Login',
				controller: 'LoginCtrl'
			})
			.when('/logout', {
				template: '',
				controller: 'LogoutCtrl',
				perm: { authorized: true }
			})
			.when('/patients', {
				templateUrl: '/Page/Patients',
				perm: { authorized: true }
			})
			.when('/patient/view/:id', {
				templateUrl: '/Patient/Overview',
				controller: 'PatientCtrl',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/first-survey', {
				templateUrl: '/Patient/FirstSurvey',
				controller: 'PatientCtrl',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/survey', {
				templateUrl: '/Patient/Survey',
				controller: 'PatientCtrl',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/Treatment-plan', {
				templateUrl: '/Patient/TreatmentPlan',
				controller: 'PatientCtrl',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/visit', {
				templateUrl: '/Patient/visit',
				controller: 'PatientCtrl',
				perm: { authorized: true }
			})
			.when('/patient/new', {
				templateUrl: '/Patient/Editor',
				controller: 'PatientNewCtrl',
				perm: { authorized: true }
			})
			.when('/patient/edit/:id', {
				templateUrl: '/Patient/Editor',
				controller: 'PatientEditCtrl',
				perm: { authorized: true }
			})
			.when('/patient/edit/:id/Treatment-plan', {
				templateUrl: '/Patient/TreatmentPlanEditor',
				controller: 'PatientCtrl',
				perm: { authorized: true }
			})
			.when('/help', {
				templateUrl: '/Page/Help'
			})
			.when('/about', {
				templateUrl: '/Page/About'
			})
			.otherwise({ redirectTo: '/' });

		// NOTE: This part is very important
		$locationProvider.html5Mode(false).hashPrefix('!');

		// Push auth interceptor
		$httpProvider.interceptors.push('authHttpInterceptor');
	}]
	).run(function($rootScope, $location, $timeout, permSvc, URLS) {
		$rootScope.alerts = [];

		$timeout(function() {

			$rootScope.alerts.splice(0, 1);
		}, 30000);

		$rootScope.addAlert = function(alert) {
			if ($rootScope.alerts.length > 3) {
				$rootScope.alerts.splice(0, 1);
			}
			$rootScope.alerts.push(alert);
		};

		$rootScope.closeAlert = function(index) {
			$rootScope.alerts.splice(index, 1);
		};

		$rootScope.onLoadFailed = function(error) {
			console.log(error);
			$rootScope.addAlert({ type: 'danger', title: 'Ошибка при загрузке', details: 'Не удаётся загрузить данные' });
		};

		$rootScope.onSaveFailed = function(error) {
			console.log(error);
			$rootScope.addAlert({ type: 'danger', title: 'Ошибка при сохранении', details: 'Не удаётся сохранить данные' });
		};

		$rootScope.goUp = function(breadcrumb) {
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

		$rootScope.checkPerm = permSvc.checkPerm;
	
		// Check perm before page change
		$rootScope.$on('$routeChangeStart', function (event, currRoute, prevRoute) {
			if (!permSvc.checkPerm(currRoute.perm)) {
				$location.path(URLS.login);
			}
		});
	});