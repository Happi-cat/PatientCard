'use strict';

angular.module('dentalPatientCardApp')
  .controller('FooterCtrl', function ($scope, Auth) {
    var self = $scope;

    self.isCollapsed = true;

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
	];
	
	self.checkItemPerm = function (item) {
		if (item.auth) {
			return Auth.isInRole(item.auth);
		}
		return true;
	};

  });
