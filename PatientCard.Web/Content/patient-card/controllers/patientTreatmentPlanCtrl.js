'use strict';

function PatientTreatmentPlanCtrl($scope, patientSvc, systemSvc, ROLES) {
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
		current: 'План лечения'
	};

	var options = [];
	var load = function () {
		systemSvc.getTreatmentOptions().then(function (data) {
			options = data;

			return patientSvc.getPatient($scope.patientId);
		}).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getTreatmentPlan($scope.patientId);
		}).then(function (data) {
			$scope.treatmentPlan = data;
			if (!$scope.treatmentPlan) {
				$scope.treatmentPlan = [];
			}

			angular.forEach(options, getPlan);
		}, $scope.onLoadFailed);
	};

	load();

	var getPlan = function (option) {
		var plan = null;
		angular.forEach($scope.treatmentPlan, function (item) {
			if (!plan && option.id == item.treatmentOptionId) {
				plan = item;
			}
		});

		if (!plan) {
			plan = { treatmentOptionId: option.id, patientId: $scope.patientId };
			$scope.treatmentPlan.push(plan);
		}
		plan.name = option.name;
		plan.order = option.order;
		plan.group = option.group;
	};

	$scope.ok = function () {
		patientSvc.storeTreatmentPlan($scope.treatmentPlan).then(function (data) {
			$scope.goUp($scope.breadcrumb);
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.goUp($scope.breadcrumb);
	};
}
