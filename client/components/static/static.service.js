'use strict';

angular.module('dentalPatientCardApp')
	.factory('Static', function($resource) {
		return $resource('/api/static/:controller', {}, {
			surveyTypes: {
				method: 'GET',
				isAray: true,
				params: {
					controller: 'survey-types'
				},
			},
			roles: {
				method: 'GET',
				isAray: true,
				params: {
					controller: 'roles'
				},
			},
			firstsurveyOptions: {
				method: 'GET',
				isAray: true,
				params: {
					controller: 'first-survey-options'
				},
			},
			treatmentPlans: {
				method: 'GET',
				isAray: true,
				params: {
					controller: 'treatment-plans'
				},
			}
		});
	});