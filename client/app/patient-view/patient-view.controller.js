'use strict';

angular.module('patientCardApp')
  .controller('PatientViewCtrl', function ($scope, $routeParams, patientService) {
    var self = $scope;

    self.patientId = $routeParams.patientId;

	self.breadcrumb = {
		items: [
			{
				title: 'Пациенты',
				url: '/patients'
			},
		],
		current: null
	};

	self.landing = [
		{
			icon: 'dentist-icon-note29',
			title: 'Редактировать карту',
			description: 'Нажмите на этот пункт если хотите изменить информацию о пациенте',
			url: '/patient/' + self.patientId + '/edit'
		},
		{
			icon: 'dentist-icon-tooth18',
			title: 'Первичное обследование',
			description: 'Заполнить (просмотреть) результаты первичного обследования пациента',
			url: '/patient/' + self.patientId + '/first-survey'
		},
		{
			icon: 'dentist-icon-toothbrush',
			title: 'План лечения',
			description: 'Выберите этот пункт если хотите посмотреть план лечения пациента',
			url: '/patient/' + self.patientId + '/treatment-plan'
		},
		{
			icon: 'dentist-icon-dentist12',
			title: 'Обследования',
			description: 'В данном разделе вы можете посмотреть результаты обследований и добавить новые результаты',
			url: '/patient/' + self.patientId + '/survey'
		},
		{
			icon: 'dentist-icon-dentist13',
			title: 'Дневник посещений',
			description: 'Выберите данный пункт если хотите посмотреть дневник посещений пациента и(или) добавить новую запись',
			url: '/patient/' + self.patientId + '/visit'
		},
		{
			icon: 'dentist-icon-tooth19',
			title: 'Стоматологический статус',
			description: 'Здесь вы можете узнать стоматологический статус для данного пациента',
			url: '/patient/' + self.patientId + '/status'
		}
	];

	var load = function () {
		patientService.getPatient(self.patientId).then(function (data) {
			self.patient = data;
			self.breadcrumb.current = data.displayName;
		}, function (error) {
			self.addAlert({ type: 'danger', title: error.status, details: error.message })
		});
	};

	load();
  });
