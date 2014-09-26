'use strict';

function PatientThreatmentPlanCtrl($scope, patientSvc, systemSvc) {
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
		systemSvc.getThreatmentOptions().then(function (data) {
			options = data;

			return patientSvc.getPatient($scope.patientId);
		}).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getThreatmentPlan($scope.patientId);
		}).then(function (data) {
			$scope.threatmentPlan = data;
			if (!$scope.threatmentPlan) {
				$scope.threatmentPlan = [];
			}

			angular.forEach(options, getPlan);
		}, $scope.onLoadFailed);
	};

	load();

	var getPlan = function (option) {
		var plan = null;
		angular.forEach($scope.threatmentPlan, function (item) {
			if (!plan && option.id == item.threatmentOptionId) {
				plan = item;
			}
		});

		if (!plan) {
			plan = { threatmentOptionId: option.id, patientId: $scope.patientId };
			$scope.threatmentPlan.push(plan);
		}
		plan.name = option.name;
		plan.order = option.order;
		plan.group = option.group;
	};

	$scope.ok = function () {
		patientSvc.storeThreatmentPlan($scope.threatmentPlan).then(function (data) {
			$scope.goUp($scope.breadcrumb);
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.goUp($scope.breadcrumb);
	};
}
