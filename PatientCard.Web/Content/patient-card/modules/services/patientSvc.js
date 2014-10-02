'use strict';

angular.module('patient-card.services')
	.factory('patientSvc', function($http, $q) {
		var self = {};

		var httpWrap = function(obj) {
			var deferred = $q.defer();
			$http(obj).then(function (data) {
				if (data.data == 'null') {
					deferred.resolve(null);
				} else {
					deferred.resolve(data.data);
				}
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
			return httpWrap({ method: 'GET', url: '/api/patient', params: { id: id } }).then(function (data) {
				var deferred = $q.defer();
				deferred.resolve(data);
				return deferred.promise;
			});
		};

		self.storePatient = function(patient) {
			return httpWrap({ method: 'POST', url: '/api/patient', data: patient });
		};

		self.getFirstSurvey = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/first-survey',
				params: {
					patientId: patientId
				}
			});
		};

		self.storeFirstSurvey = function(survey) {
			return httpWrap({ method: 'POST', url: '/api/patient/first-survey', data: survey });
		};

		self.getSurveys = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/survey',
				params: {
					patientId: patientId
				}
			});
		};

		self.storeSurvey = function(survey) {
			return httpWrap({ method: 'POST', url: '/api/patient/survey', data: survey });
		};

		self.getTreatmentPlan = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/Treatment-plan',
				params: {
					patientId: patientId
				}
			});
		};

		self.storeTreatmentPlan = function(TreatmentPlan) {
			return httpWrap({ method: 'POST', url: '/api/patient/Treatment-plan', data: TreatmentPlan });
		};

		self.getVisit = function(patientId) {
			return httpWrap({
				method: 'GET',
				url: '/api/patient/visit',
				params: {
					patientId: patientId
				}
			});
		};

		self.storeVisit = function(diary) {
			return httpWrap({ method: 'POST', url: '/api/patient/visit', data: diary });
		};

		return self;
	});