'use strict';

angular.module('dentalPatientCardApp')
	.factory('PatientVisit', function($resource) {
        return $resource('/api/patients/:patientId/visit', {
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
