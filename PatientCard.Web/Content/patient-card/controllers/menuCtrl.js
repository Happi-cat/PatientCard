'use strict';

function MenuCtrl(permSvc, ROLES) {
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
	
	self.checkItemPerm = function (item) {
		return permSvc.checkPerm(item.perm);
	};

	return self;
}