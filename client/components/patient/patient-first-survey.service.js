'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientFirstSurvey', function($resource) {
        return $resource('/api/patients/:patientId/first-survey', {
            patientId: '@patientId'
        }, {
            get: {
                method: 'GET',
            },
            update: {
                method: 'POST',
            }
        });
    });
