'use strict';

angular.module('patient-card.services')
	.factory('systemSvc', function($http, $q) {
		var self = {};

		var httpWrap = function(obj) {
			var deferred = $q.defer();
			$http(obj).then(function(data) {
				if (data.data == 'null') {
					deferred.resolve(null);
				} else {
					deferred.resolve(data.data);
				}
			}, function(data) {
				deferred.reject({
					status: data.status,
					message: data.statusText,
				});
			});
			return deferred.promise;
		};

		self.getJobs = function() {
			return httpWrap({ method: 'GET', url: '/api/system/jobs', cache: true });
		};

		self.getSurveyTypes = function() {
			return httpWrap({ method: 'GET', url: '/api/system/survey-types', cache: true });
		};

		self.getFirstSurveyOptions = function() {
			return httpWrap({ method: 'GET', url: '/api/system/first-survey-options', cache: true });
		};

		self.getThreatmentOptions = function() {
			return httpWrap({ method: 'GET', url: '/api/system/threatment-options', cache: true });
		};

		return self;
	});