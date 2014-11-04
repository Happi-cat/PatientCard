'use strict';

function PatientListCtrl($scope, patientSvc) {
	var self = this;

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
		patientSvc.getPatients().then(function(data) {
			self.items = data;
		}, $scope.onLoadFailed);
	};

	load();
}
