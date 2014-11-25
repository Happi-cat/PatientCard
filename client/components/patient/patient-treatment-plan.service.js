'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientTreatmentPlan', function($resource) {
        return $resource('/api/patients/:patientId/treatment-plan', {
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
