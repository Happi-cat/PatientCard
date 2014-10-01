'use strict';

function PatientEditCtrl($scope, $routeParams, patientSvc) {
	$scope.patientId = $routeParams.id;
	$scope.edit = true;
	
	$scope.breadcrumb = {
		items: [
			{
				title: 'Пациенты',
				url: '/patients'
			},
			{
				title: 'Пациент',
				url: '/patient/view/' + $scope.patientId
			}
		],
		current: 'Редактирование'
	};
	$scope.gender = [
		{
			id: 'male',
			value: 'Муж.'
		},
		{
			id: 'female',
			value: 'Жен.'
		}
	];


	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.displayName;

		}, $scope.onLoadFailed);
	};

	load();

	$scope.ok = function () {
		patientSvc.storePatient($scope.patient).then(function (data) {
			$scope.goUp($scope.breadcrumb);
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.goUp($scope.breadcrumb);
	};

	$scope.open = function ($event) {
		$event.preventDefault();
		$event.stopPropagation();

		$scope.opened = true;
	};


}