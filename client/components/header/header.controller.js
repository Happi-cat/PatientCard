'use strict';

angular.module('patientCardApp')
  .controller('HeaderCtrl', function ($scope, authService, ROLES) {
    var self = $scope;

    self.isCollapsed = true;
    self.isActionOpened = false;

	self.menu = [
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

	self.actions = [
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
		return authService.checkPerm(item.perm);
	};

  });
