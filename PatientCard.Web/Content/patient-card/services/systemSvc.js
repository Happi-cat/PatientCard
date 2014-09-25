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

		var firstSurveyData;
		self.getFirstSurveyOptions = function () {
			var deferred = $q.defer();
			if (!firstSurveyData) {
				$http.get('/api/system/first-survey-options').then(function(data) {
					firstSurveyData = data.data;
					deferred.resolve(data.data);
				});
			} else {
				deferred.resolve(firstSurveyData);
			}
			return deferred.promise;
		};

		var threatmentOptionsData;
		self.getThreatmentOptions = function () {
			var deferred = $q.defer();
			if (!threatmentOptionsData) {
				$http.get('/api/system/threatment-options').then(function (data) {
					threatmentOptionsData = data.data;
					deferred.resolve(data.data);
				});
			} else {
				deferred.resolve(threatmentOptionsData);
			}
			return deferred.promise;
		};

		return self;
	});