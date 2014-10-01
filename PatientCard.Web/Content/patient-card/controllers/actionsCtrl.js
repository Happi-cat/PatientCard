'use strict';

function ActionsCtrl() {
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

	return self;
}