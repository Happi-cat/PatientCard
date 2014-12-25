'use strict';

angular.module('dentalPatientCardApp')
    .factory('Patient', function($resource) {
        return $resource('/api/patients/:patientId', {
            patientId: '@patientId'
        }, {
            all: {
                method: 'GET',
                isAray: true,
            },
            get: {
                method: 'GET'
            },
            create: {
                method: 'POST'
            },
            update: {
                method: 'PUT'
            }
        });
    });