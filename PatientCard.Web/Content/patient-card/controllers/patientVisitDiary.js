'use strict';

function PatientVisitDiaryCtrl($scope, patientSvc) {
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

	$scope.visitDiary = {};

	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.lastName + ' ' + data.firstName + ' ' + data.middleName;

			return patientSvc.getVisitDiary($scope.patientId);
		}).then(function (data) {
			$scope.visits = data;
		}, $scope.onLoadFailed);
	};

	load();

	$scope.ok = function () {
		$scope.visitDiary.patientId = $scope.patientId;
		patientSvc.storeVisitDiary($scope.visitDiary).then(function (data) {
			$scope.visitDiaryForm.$setPristine();
			$scope.visitDiary = {};
			load();
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.visitDiaryForm.$setPristine();
		$scope.visitDiary = {};
	};
}
