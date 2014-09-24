'use strict';

angular.module('patient-card.services')
	.factory('patientSvc', function($http, $q) {
		var self = {};

		var httpWrap = function(obj) {
			var deferred = $q.defer();
			$http(obj).then(function(data) {
				deferred.resolve(data.data);
			}, function (data) {
				deferred.reject({
					status: data.status,
					message: data.statusText,
				});
			});
			return deferred.promise;
		};

		self.getPatients = function() {
			return httpWrap({ method: 'GET', url: '/api/patient' });
		};

		self.getPatient = function(id) {
			return httpWrap({ method: 'GET', url: '/api/patient', params: { id: id } });
		};

		self.storePatient = function(patient) {
			return httpWrap({ method: 'POST', url: '/api/patient', data: patient });
		};

		self.getFirstSurvey = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/first-survey/:id',
				params: {
					id: patientId
				}
			});
		};

		self.storeFirstSurveyDetails = function(surveyDetails) {
			return httpWrap({ method: 'POST', url: '/api/patient/firs-survey-details', data: surveyDetails });
		};

		self.getSurveys = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/survey',
				params: {
					id: patientId
				}
			});
		};

		self.storeSurvey = function(survey) {
			return httpWrap({ method: 'POST', url: '/api/patient/survey', data: survey });
		};

		self.getThreatmentPlan = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/threatment-plan',
				params: {
					id: patientId
				}
			});
		};

		self.storeThreatmentPlan = function(threatmentPlan) {
			return httpWrap({ method: 'POST', url: '/api/patient/threatment-plan', data: threatmentPlan });
		};

		self.getVisitDiary = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/visit-diary/:id',
				params: {
					id: patientId
				}
			});
		};

		self.storeVisitDiary = function(diary) {
			return httpWrap({ method: 'POST', url: '/api/patient/visit-diary', data: diary });
		};

		return self;
	});