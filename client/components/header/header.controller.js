'use strict';

angular.module('dentalPatientCardApp')
  .controller('HeaderCtrl', function ($scope, Auth) {
    var self = $scope;

    self.isCollapsed = true;
    self.isActionOpened = false;

	self.menu = [
		{
			title: 'Пациенты',
			url: '/patients',
			auth: true,
		},
		{
			title: 'Пользователи',
			url: '/users',
			auth: 'administrator',
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
			auth: true,
		},
		{
			title: 'Выйти',
			url: '/logout',
			auth: true,
		}
	];
	
	self.checkItemPerm = function (item) {
		if (item.auth) {
			return Auth.isInRole(item.auth);
		}
		return true;
	};

  });
