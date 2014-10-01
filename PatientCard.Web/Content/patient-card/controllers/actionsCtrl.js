'use strict';

function ActionsCtrl(permSvc) {
	var self = {};
	self.items = [
		{
			title: 'Справка',
			url: '/help',
		},
		{
			title: 'О нас',
			url: '/about',
		},
		{
			divider: true,
			perm: {
				authorized: true,
			}
		},
		{
			title: 'Выйти',
			url: '/logout',
			perm: {
				authorized: true,
			}
		}
	];

	self.checkItemPerm = function (item) {
		return permSvc.checkPerm(item.perm);
	};

	return self;
}