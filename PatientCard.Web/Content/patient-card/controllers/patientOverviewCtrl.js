'use strict';

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
