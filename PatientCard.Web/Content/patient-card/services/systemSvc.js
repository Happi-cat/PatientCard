'use strict';

angular.module('patient-card.services')
	.factory('systemSvc', function ($http, $q) {
		var self = {};
		
		self.jobs = function () {
			return $http.get('/api/system/jobs');
		};
		
		self.surveyTypes = function () {
			return $http.get('/api/system/survey-types');
		};
		
		self.firstSurveyOptions = function () {
			return $http.get('/api/system/first-survey-options');
		};
		
		self.threatmentOptions = function () {
			return $http.get('/api/system/threatment-options');
		};

		return self;
	});