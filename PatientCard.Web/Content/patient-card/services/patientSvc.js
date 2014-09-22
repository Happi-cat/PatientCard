'use strict';

angular.module('patient-card.services')
	.factory('patientSvc', function ($http, $q) {
		var self = {};

		self.getPatients = function() {
			return $http.get('/api/patient');
		};

		self.getPatient = function(id) {
			return $http.get('/api/patient/:id', {
				params: {
					id: id
				}
			});
		};

		self.storePatient = function(patient) {
			return $http.post('/api/patient', patient);
		};

		self.getFirstSurvey = function(patientId) {
			return $http.get('/api/patient/first-survey/:id', {
				params: {
					id: patientId
				}
			});
		};

		self.storeFirstSurveyDetails = function(surveyDetails) {
			return $http.post('/api/patient/firs-survey-details', surveyDetails);
		};
		
		self.getSurveys = function (patientId) {
			return $http.get('/api/patient/survey/:id', {
				params: {
					id: patientId
				}
			});
		};

		self.storeSurvey = function (survey) {
			return $http.post('/api/patient/survey', survey);
		};
		
		self.getThreatmentPlan = function (patientId) {
			return $http.get('/api/patient/threatment-plan/:id', {
				params: {
					id: patientId
				}
			});
		};

		self.storeThreatmentPlan = function (threatmentPlan) {
			return $http.post('/api/patient/threatment-plan', threatmentPlan);
		};

		self.getVisitDiary = function (patientId) {
			return $http.get('/api/patient/visit-diary/:id', {
				params: {
					id: patientId
				}
			});
		};

		self.storeVisitDiary = function (diary) {
			return $http.post('/api/patient/visit-diary', diary);
		};

		return self;
	});