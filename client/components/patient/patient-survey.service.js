'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientSurvey', function($resource) {
        return $resource('/api/patients/:patientId/survey', {
            patientId: '@patientId'
        }, {
            all: {
                method: 'GET',
                isAray: true,
            },
            create: {
                method: 'POST',
            },
            update: {
                method: 'PUT',
            }
        });
    });
