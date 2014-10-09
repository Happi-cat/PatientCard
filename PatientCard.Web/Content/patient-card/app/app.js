'use strict';

var webapp = angular.module('patient-card-app', ['patient-card.services', 'patient-card.directives', 'patient-card.auth', 'ui.bootstrap', 'ui.router', 'nvd3ChartDirectives', 'ngRoute'])
	.constant('URLS', {
		login: '/login',
		home: '/',
		logout: '/logout',
	})
	.config(['$routeProvider', '$locationProvider', '$httpProvider', function ($routeProvider, $locationProvider, $httpProvider) {
		$routeProvider
			.when('/', {
				templateUrl: '/Page/Home',
				controller: 'LandingCtrl as landing',
				perm: { authorized: true }
			})
			.when('/login', {
				templateUrl: '/Page/Login',
				controller: 'LoginCtrl as login'
			})
			.when('/logout', {
				template: '',
				controller: 'LogoutCtrl',
				perm: { authorized: true }
			})
			.when('/patients', {
				templateUrl: '/Page/Patients',
				controller: 'PatientListCtrl as patientList',
				perm: { authorized: true }
			})
			.when('/patient/view/:id', {
				templateUrl: '/Patient/Overview',
				controller: 'PatientOverviewCtrl as overview',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/first-survey', {
				templateUrl: '/Patient/FirstSurvey',
				controller: 'PatientFirstSurveyCtrl as firstSurvey',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/survey', {
				templateUrl: '/Patient/Survey',
				controller: 'PatientSurveyCtrl as survey',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/treatment-plan', {
				templateUrl: '/Patient/TreatmentPlan',
				controller: 'PatientTreatmentPlanCtrl as treatmentPlan',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/visit', {
				templateUrl: '/Patient/Visit',
				controller: 'PatientVisitCtrl as visit',
				perm: { authorized: true }
			})
			.when('/patient/view/:id/status', {
				templateUrl: '/Patient/Status',
				controller: 'PatientStatusCtrl as status',
				perm: { authorized: true }
			})
			.when('/patient/new', {
				templateUrl: '/Patient/Editor',
				controller: 'PatientNewCtrl as editor',
				perm: { authorized: true }
			})
			.when('/patient/edit/:id', {
				templateUrl: '/Patient/Editor',
				controller: 'PatientEditCtrl as editor',
				perm: { authorized: true }
			})
			.when('/patient/edit/:id/treatment-plan', {
				templateUrl: '/Patient/TreatmentPlanEditor',
				controller: 'PatientTreatmentPlanCtrl as treatmentPlan',
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
	).run(function ($rootScope, $location, $timeout, authSvc, permSvc, URLS) {
		$rootScope.alerts = [];

		$timeout(function () {

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

		$rootScope.onSaveFailed = function (error) {
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

		$rootScope.checkPerm = permSvc.checkPerm;

		// Check perm before page change
		$rootScope.$on('$routeChangeStart', function (event, currRoute, prevRoute) {
			if (!permSvc.checkPerm(currRoute.perm)) {
				authSvc.loginByCookie().catch(function(data) {
					 $location.path(URLS.login);
				});
			}
		});
	});