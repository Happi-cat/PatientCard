'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientStatusOhis', function($resource) {
        return $resource('/api/patients/:patientId/status/ohis', {
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
