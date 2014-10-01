'use strict';

function MenuCtrl($scope, ROLES) {
	var self = {};
	self.items = [
		{
			title: 'Пациенты',
			url: '/patients',
			perm: {
				authorized: true
			}
		},
		{
			title: 'Пользователи',
			url: '/users',
			perm: {
				role: ROLES.admin
			}
		},
	];

	return self;
}