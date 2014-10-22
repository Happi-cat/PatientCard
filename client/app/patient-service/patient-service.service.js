'use strict';

angular.module('patientCardApp')
.factory('patientService', function ($http, $q, $resource) {
    var self = {};

    self.getPatients = function() {
      return $resource('/api/patient').query().$promise;
    };

    self.getPatient = function(id) {
      return $resource('/api/patient/:id', { id: id }).get().$promise;
    };

    self.storePatient = function(patient) {
      return $resource('/api/patient').save(patient).$promise;
    };

    self.getFirstSurvey = function(patientId) {
      return $resource('/api/patient/:id/first-survey', { id: patientId }).get().$promise;
    };

    self.storeFirstSurvey = function(survey) {
      return $resource('/api/patient/:id/first-survey', { id: patientId }).save(survey).$promise;
    };

    self.getSurveys = function(patientId) {
      return $resource('/api/patient/:id/survey', { id: patientId }).query().$promise;
    };

    self.storeSurvey = function(survey) {
      return $resource('/api/patient/:id/survey', { id: patientId }).save(survey).$promise;
    };

    self.getTreatmentPlan = function(patientId) {
      return $resource('/api/patient/:id/treatment-plan', { id: patientId }).get().$promise;
    };

    self.storeTreatmentPlan = function(treatmentPlan) {
      return $resource('/api/patient/:id/treatment-plan', { id: patientId }).save(treatmentPlan).$promise;
    };

    self.getVisit = function(patientId) {
      return $resource('/api/patient/:id/visit', { id: patientId }).query().$promise;
    };

    self.storeVisit = function(visit) {
      return $resource('/api/patient/:id/visit', { id: patientId }).save(visit).$promise;
    };

    self.getDentistStatuses = function (patientId) {
      return $resource('/api/patient/:id/dentist-status', { id: patientId }).query().$promise;
    };

    self.storeDentistStatus = function (status) {
      return $resource('/api/patient/:id/dentist-status', { id: patientId }).save(status).$promise;
    };
    
    self.getOhisStatuses = function (patientId) {
      return $resource('/api/patient/:id/ohis-status', { id: patientId }).query().$promise;
    };

    self.storeOhisStatus = function (status) {
      return $resource('/api/patient/:id/ohis-status', { id: patientId }).save(status).$promise;
    };
    
    self.getCpiStatuses = function (patientId) {
      return $resource('/api/patient/:id/cpi-status', { id: patientId }).query().$promise;
    };

    self.storeCpiStatus = function (status) {
      return $resource('/api/patient/:id/cpi-status', { id: patientId }).save(status).$promise;
    };
    
    self.getDfmStatuses = function (patientId) {
      return $resource('/api/patient/:id/dfm-status', { id: patientId }).query().$promise;
    };

    self.storeDfmStatus = function (status) {
      return $resource('/api/patient/:id/dfm-status', { id: patientId }).save(status).$promise;
    };

    return self;
  });
