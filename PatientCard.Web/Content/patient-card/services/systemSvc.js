'use strict';

angular.module('patient-card.services')
	.factory('systemSvc', function ($http, $q) {
		var self = {};

		$http.get('/api/system/jobs').then(function(data) {
			self.jobs = data;
		});

		$http.get('/api/system/survey-types').then(function (data) {
			self.surveyTypes = data;
		});
		
		$http.get('/api/system/first-survey-options').then(function (data) {
			self.firstSurveyOptions = data;
		});
		
		$http.get('/api/system/threatment-options').then(function (data) {
			self.threatmentOptions = data;
		});

		return self;
	});