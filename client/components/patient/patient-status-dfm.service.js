'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientStatusDfm', function($resource) {
        return $resource('/api/patients/:patientId/status/dfm', {
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
