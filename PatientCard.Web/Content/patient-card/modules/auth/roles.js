'use strict';

angular.module('patient-card.auth')
	.constant('ROLES', {
		admin: 'Administrator',
		doctor: 'Doctor',
		nurse: 'Nurse'
	});