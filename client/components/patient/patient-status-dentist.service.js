'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientStatusDentist', function($resource) {
        return $resource('/api/patients/:patientId/status/dentist', {
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
        })
    });