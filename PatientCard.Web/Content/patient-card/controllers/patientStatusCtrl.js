'use strict';

function PatientStatusCtrl($scope, patientSvc, ROLES) {
	$scope.editPerm = {
		role: [ROLES.doctor, ROLES.admin]
	};

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
		current: 'Стоматологический статус'
	};	
	
	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.displayName;
		}, $scope.onLoadFailed);
	};

	load();
}

function PatientDentistStatusCtrl($scope, patientSvc) {
	var load = function () {
		patientSvc.getDentistStatuses($scope.patientId).then(function (data) {
			$scope.dentistStatuses = data;
		}, $scope.onLoadFailed);
	};

	load();

	$scope.editFormEnabled = false;

	$scope.add = function() {
		$scope.editFormEnabled = true;
	};

	$scope.status = {};

	$scope.ok = function () {
		$scope.status.patientId = $scope.patientId;
		patientSvc.storeDentistStatus($scope.status).then(function (data) {
			$scope.status = {};
			load();
			$scope.editFormEnabled = false;
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.status = {};
		$scope.editFormEnabled = false;
	};
}

function PatientOhisStatusCtrl($scope, patientSvc) {
	var load = function () {
		patientSvc.getOhisStatuses($scope.patientId).then(function (data) {
			$scope.ohisStatuses = data;
		}, $scope.onLoadFailed);
	};

	load();
	
	$scope.editFormEnabled = false;
	
	$scope.add = function () {
		$scope.editFormEnabled = true;
	};
	
	$scope.status = {};

	$scope.ok = function () {
		$scope.status.patientId = $scope.patientId;
		patientSvc.storeOhisStatus($scope.status).then(function (data) {
			$scope.status = {};
			load();
			$scope.editFormEnabled = false;
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.status = {};
		$scope.editFormEnabled = false;
	};
}

function PatientDfmStatusCtrl($scope, patientSvc) {
	var load = function () {
		patientSvc.getDfmStatuses($scope.patientId).then(function (data) {
			$scope.dfmStatuses = data;
		}, $scope.onLoadFailed);
	};

	load();
	
	$scope.editFormEnabled = false;
	
	$scope.add = function () {
		$scope.editFormEnabled = true;
	};
	
	$scope.status = {};

	$scope.ok = function () {
		$scope.status.patientId = $scope.patientId;
		patientSvc.storeDfmStatus($scope.status).then(function (data) {
			$scope.status = {};
			load();
			$scope.editFormEnabled = false;
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.status = {};
		$scope.editFormEnabled = false;
	};
}

function PatientCpiStatusCtrl($scope, patientSvc) {
	var load = function () {
		patientSvc.getCpiStatuses($scope.patientId).then(function (data) {
			$scope.cpiStatuses = data;
		}, $scope.onLoadFailed);
	};

	load();
	
	$scope.editFormEnabled = false;
	
	$scope.add = function () {
		$scope.editFormEnabled = true;
	};
	
	$scope.status = {};

	$scope.ok = function () {
		$scope.status.patientId = $scope.patientId;
		patientSvc.storeCpiStatus($scope.status).then(function (data) {
			$scope.status = {};
			load();
			$scope.editFormEnabled = false;
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.status = {};
		$scope.editFormEnabled = false;
	};
}

