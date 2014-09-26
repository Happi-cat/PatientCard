'use strict';

function PatientFirstSurveyCtrl($scope, patientSvc, systemSvc) {
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
		current: 'Первичный осмотр'
	};

	var options = [];
	var load = function () {
		systemSvc.getFirstSurveyOptions().then(function (data) {
			options = data;

			return patientSvc.getPatient($scope.patientId);
		}).then(function (data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.lastName + ' ' + data.firstName + ' ' + data.middleName;

			return patientSvc.getFirstSurvey($scope.patientId);
		}).then(function (data) {
			$scope.firstSurvey = data;
			if (!$scope.firstSurvey) {
				$scope.firstSurvey = {
					patientId: $scope.patientId
				};
			}

			angular.forEach(options, getDetail);
		}, $scope.onLoadFailed);
	};

	load();

	var getDetail = function (option) {
		if (!$scope.firstSurvey.details) {
			$scope.firstSurvey.details = [];
		}

		var detail = null;
		angular.forEach($scope.firstSurvey.details, function (item) {
			if (option.id == item.surveyOptionId) {
				detail = item;
			}
		});

		if (!detail) {
			detail = { surveyOptionId: option.id, patientId: $scope.patientId };
			$scope.firstSurvey.details.push(detail);
		}
		detail.value = option.value;
	};

	$scope.ok = function () {
		$scope.firstSurvey.patientId = $scope.patientId;
		patientSvc.storeFirstSurvey($scope.firstSurvey).then(function (data) {
			$scope.goUp($scope.breadcrumb);
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.goUp($scope.breadcrumb);
	};
}