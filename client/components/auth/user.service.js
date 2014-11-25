'use strict';

angular.module('dentalPatientCardApp')
	.factory('User', function($resource) {
		return $resource('/api/users/:id', {
			id: '@id'
		}, {
			get: {
				method: 'GET',
				params: {
					id: 'me'
				}
			}
		});
	});