'use strict';

angular.module('patientCardApp')
  .controller('PatientListCtrl', function ($scope, patientService) {
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
		patientService.getPatients().then(function(data) {
			self.items = data;
		}, self.onLoadFailed);
	};

	load();
  });
