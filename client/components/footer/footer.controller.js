'use strict';

angular.module('patientCardApp')
  .controller('FooterCtrl', function ($scope, authService, ROLES) {
    var self = $scope;

    self.isCollapsed = true;

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
	];
	
	self.checkItemPerm = function (item) {
		return authService.checkPerm(item.perm);
	};

  });
