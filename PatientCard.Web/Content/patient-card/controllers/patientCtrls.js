'use strict';

function PatientCtrl($scope, $routeParams) {
	$scope.patientId = $routeParams.id;
}

function PatientOverviewCtrl($scope, patientSvc) {
	$scope.breadcrumb = {
		items: [
			{
				title: 'Пациенты',
				url: '/patients'
			},
		],
		current: null
	};

	$scope.landing = [
		{
			icon: 'health-icon-prescription',
			title: 'Редактировать карту',
			description: 'Нажмите на этот пункт если хотите изменить информацию о пациенте',
			url: '/patient/edit/' + $scope.patientId
		},
		{
			icon: 'health-icon-onlinepharmacycheck',
			title: 'Первичное обследование',
			description: 'Заполнить (просмотреть) результаты первичного обследования пациента',
			url: '/patient/view/' + $scope.patientId + '/first-survey'
		},
		{
			icon: 'health-icon-capsule',
			title: 'План лечения',
			description: 'Выберите этот пункт если хотите посмотреть план лечения пациента',
			url: '/patient/view/' + $scope.patientId + '/threatment-plan'
		},
		{
			icon: 'health-icon-microscope',
			title: 'Обследования',
			description: 'В данном разделе вы можете посмотреть результаты обследований и добавить новые результаты',
			url: '/patient/view/' + $scope.patientId + '/survey'
		},
		{
			icon: 'health-icon-sthetoscope',
			title: 'Дневник посещений',
			description: 'Выберите данный пункт если хотите посмотреть дневник посещений пациента и(или) добавить новую запись',
			url: '/patient/view/' + $scope.patientId + '/visit-diary'
		}];

	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;
			$scope.breadcrumb.current = data.lastName + ' ' + data.firstName + ' ' + data.middleName;
		}, function (error) {
			$scope.addAlert({ type: 'danger', title: error.status, details: error.message })
		});
	};

	load();
}



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
					patientId : $scope.patientId
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

function PatientSurveyCtrl($scope, patientSvc)
{
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

	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;
			var item = $scope.breadcrumb.items[1];
			item.title = data.lastName + ' ' + data.firstName + ' ' + data.middleName;
		}, function (error) {
			$scope.addAlert({ type: 'danger', title: error.status, details: error.message })
		});
	};

	load();
	
}

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
			item.title = data.lastName + ' ' + data.firstName + ' ' + data.middleName;

			return patientSvc.getThreatmentPlan($scope.patientId);
		}).then(function (data) {
			$scope.threatmentPlan = data;
			if (!$scope.threatmentPlan) {
				$scope.threatmentPlan = [ ];
			}

			angular.forEach(options, getPlan);
		}, $scope.onLoadFailed);
	};

	load();

	var getPlan = function (option) {
		var plan = null;
		angular.forEach($scope.threatmentPlan, function (item) {
			if (option.id == item.threatmentOptionId) {
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

function PatientVisitDiaryCtrl($scope, patientSvc) {
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

	var load = function () {
		patientSvc.getPatient($scope.patientId).then(function (data) {
			$scope.patient = data;
			var item = $scope.breadcrumb.items[1];
			item.title = data.lastName + ' ' + data.firstName + ' ' + data.middleName;
		}, function (error) {
			$scope.addAlert({ type: 'danger', title: error.status, details: error.message })
		});
	};

	load();
}

