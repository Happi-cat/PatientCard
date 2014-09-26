'use strict';

function PatientListCtrl($scope, patientSvc) {
	$scope.tablehead = [
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

	$scope.items = [];
	$scope.sortFields = [];

	var load = function() {
		patientSvc.getPatients().then(function(data) {
			$scope.items = data;
		}, function(error) {
			console.log(error);
		});
	};

	load();
}
