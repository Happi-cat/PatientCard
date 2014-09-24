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

function PatientEditorCtrl($scope, patientSvc) {
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
	
	$scope.today = function () {
		$scope.dt = new Date();
	};
	$scope.today();

	$scope.clear = function () {
		$scope.dt = null;
	};

	// Disable weekend selection
	$scope.disabled = function (date, mode) {
		return (mode === 'day' && (date.getDay() === 0 || date.getDay() === 6));
	};

	$scope.toggleMin = function () {
		$scope.minDate = $scope.minDate ? null : new Date();
	};
	$scope.toggleMin();

	$scope.open = function ($event) {
		$event.preventDefault();
		$event.stopPropagation();

		$scope.opened = true;
	};

	$scope.dateOptions = {
		formatYear: 'yy',
		startingDay: 1
	};

	$scope.initDate = new Date('2016-15-20');
	$scope.formats = ['dd-MMMM-yyyy', 'yyyy/MM/dd', 'dd.MM.yyyy', 'shortDate'];
	$scope.format = $scope.formats[0];
}

function PatientFirstSurveyCtrl($scope, patientSvc) {
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

function PatientThreatmentPlan($scope, patientSvc) {
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

function PatientVisitDiary($scope, patientSvc) {
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

function PatientEdit($scope, patientSvc) {
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

function PatientNew($scope, patientSvc) {
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