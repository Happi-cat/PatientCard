'use strict';

angular.module('patientCardApp')
  .service('staticService', function ($resource) {
    // AngularJS will instantiate a singleton by calling "new" on this function
    var self = {};

		self.getJobs = function() {
			return $resource('/api/system/job').query().$promise;
		};

		self.getSurveyTypes = function() {
			return $resource('/api/system/survey-type').query().$promise;
		};

		self.getFirstSurveyOptions = function() {
			return $resource('/api/system/first-survey-option').query().$promise;
		};

		self.getTreatmentOptions = function() {
			return $resource('/api/system/treatment-option').query().$promise;
		};

		return self;
  });
