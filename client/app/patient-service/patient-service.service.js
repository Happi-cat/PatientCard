'use strict';

angular.module('patientCardApp')
.factory('patientService', function ($http, $q) {
    var self = {};

    var httpWrap = function(obj) {
      obj.url = 'http://localhost:10762' + obj.url;

      var deferred = $q.defer();
      $http(obj).then(function (data) {
        if (data.data === 'null') {
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
        url: '/api/patient/treatment-plan',
        params: {
          patientId: patientId
        }
      });
    };

    self.storeTreatmentPlan = function(treatmentPlan) {
      return httpWrap({ method: 'POST', url: '/api/patient/treatment-plan', data: treatmentPlan });
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

    self.getDentistStatuses = function (patientId) {
      return httpWrap({
        method: 'GET',
        url: '/api/patient/dentist-status',
        params: {
          patientId: patientId
        }
      });
    };

    self.storeDentistStatus = function (status) {
      return httpWrap({ method: 'POST', url: '/api/patient/dentist-status', data: status });
    };
    
    self.getOhisStatuses = function (patientId) {
      return httpWrap({
        method: 'GET',
        url: '/api/patient/ohis-status',
        params: {
          patientId: patientId
        }
      });
    };

    self.storeOhisStatus = function (status) {
      return httpWrap({ method: 'POST', url: '/api/patient/ohis-status', data: status });
    };
    
    self.getCpiStatuses = function (patientId) {
      return httpWrap({
        method: 'GET',
        url: '/api/patient/cpi-status',
        params: {
          patientId: patientId
        }
      });
    };

    self.storeCpiStatus = function (status) {
      return httpWrap({ method: 'POST', url: '/api/patient/cpi-status', data: status });
    };
    
    self.getDfmStatuses = function (patientId) {
      return httpWrap({
        method: 'GET',
        url: '/api/patient/dfm-status',
        params: {
          patientId: patientId
        }
      });
    };

    self.storeDfmStatus = function (status) {
      return httpWrap({ method: 'POST', url: '/api/patient/dfm-status', data: status });
    };

    return self;
  });
