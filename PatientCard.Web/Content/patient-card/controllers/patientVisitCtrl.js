'use strict';

function PatientVisitCtrl($scope, patientSvc, ROLES) {
	$scope.editPerm = {
		role: [ROLES.doctor, ROLES.admin]
	};
	
	$scope.tablehead = [
			{
				name: 'description',
				title: 'Описание'
			},
			{
				name: 'doctor',
				title: 'Врач',
				sortable: true,
			},
			{
				name: 'created',
				title: 'Дата',
				sortable: true
			}
	];

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
		current: 'Дневник посещений'
	};

	$scope.sortFields = [];
	$scope.visit = {};

	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getVisit($scope.patientId);
		}).then(function (data) {
			$scope.visits = data;
		}, $scope.onLoadFailed);
	};

	load();

	$scope.editFormEnabled = false;

	$scope.add = function () {
		$scope.editFormEnabled = true;
	};


	$scope.ok = function () {
		$scope.visit.patientId = $scope.patientId;
		patientSvc.storeVisit($scope.visit).then(function (data) {
			$scope.visit = {};
			load();
			$scope.editFormEnabled = false;
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.visit = {};
		$scope.editFormEnabled = false;
	};
}
