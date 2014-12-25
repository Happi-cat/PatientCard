'use strict';

angular.module('dentalPatientCardApp')
  .controller('PatientListCtrl', function ($scope, Auth, Patient) {
    var self = $scope;

	self.tablehead = [
		{
			name: 'lastName',
			title: 'Фамилия',
			sortable: true
		}, {
			name: 'firstName',
			title: 'Имя',
			sortable: true
		}, {
			name: 'middleName',
			title: 'Отчество',
			sortable: true
		}, {
			name: 'phone',
			title: 'Телефон',
		}, {
			name: 'address',
			title: 'Адрес'
		}, {
			name: 'controls',
		}
	];

	self.items = [];
	self.sortFields = [];

	var load = function() {
		Patient.all({
			token: Auth.getToken(),
		}).then(function(data) {
			self.items = data;
		}, self.onLoadFailed);
	};

	load();
  });
