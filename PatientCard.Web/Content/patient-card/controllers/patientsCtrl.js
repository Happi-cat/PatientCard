'use strict';

function PatientsCtrl($scope, patientSvc) {
	$scope.tablehead = [
		{
			name: 'lastName',
			title: 'Фамилия',
			sortable: true
		},
		{
			name: 'firstName',
			title: 'Имя',
			sortable: true
		}, {
			name: 'middleName',
			title: 'Отчество',
			sortable: true
		},
		{
			name: 'phone',
			title: 'Телефон',
			sortable: true
		}, {
			name: 'address',
			title: 'Адрес',
			sortable: true
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

function TableHeadCtrl($scope) {
	$scope.toogleSort = function (item) {
		if (item.sort == 1) {
			item.sort = -1;
		} else if (item.sort == -1) {
			item.sort = 0;
		} else {
			item.sort = 1;
		}

		$scope.sortFields.splice(0, $scope.sortFields.length);
		angular.forEach($scope.tablehead, function(column) {
			if (column.sort == 1) {
				$scope.sortFields.push(column.name);
			} else if (column.sort == -1) {
				$scope.sortFields.push('-' + column.name);
			}
		});
		
	};
}