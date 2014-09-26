'use strict';

function PatientSurveyCtrl($scope, patientSvc, systemSvc) {
	$scope.tablehead = [
		{
			name: 'type',
			title: 'Тип исследования',
			sortable: true
		},
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
		current: 'Обследования'
	};

	$scope.sortFields = [];
	$scope.survey = {};

	var load = function () {
		systemSvc.getSurveyTypes().then(function(data) {
			$scope.surveyTypes = data;

			return patientSvc.getPatient($scope.patientId);
		}).then(function(data) {
			$scope.patient = data;

			var item = $scope.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getSurveys($scope.patientId);
		}).then(function(data) {
			$scope.surveys = data;

			angular.forEach($scope.surveys, getSurvey);
		}, $scope.onLoadFailed);
	};

	load();

	var getSurvey = function (survey) {
		angular.forEach($scope.surveyTypes, function (type) {
			if (!survey.type && survey.typeId == type.id) {
				survey.type = type.value;
			}
		});
	};

	$scope.ok = function () {
		$scope.survey.patientId = $scope.patientId;
		patientSvc.storeSurvey($scope.survey).then(function (data) {
			$scope.survey = {};
			load();
		}, $scope.onSaveFailed);
	};

	$scope.cancel = function () {
		$scope.survey = {};
	};
}
