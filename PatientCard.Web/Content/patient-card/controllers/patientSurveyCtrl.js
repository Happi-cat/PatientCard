'use strict';

function PatientSurveyCtrl($routeParams, patientSvc, systemSvc, ROLES) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	self.editPerm = {
		role: [ROLES.doctor, ROLES.admin]
	};
	
	self.tablehead = [
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
		},
		{
			name: 'dose',
			title: 'Доза'
		}
	];

	self.breadcrumb = {
		items: [
			{
				title: 'Пациенты',
				url: '/patients'
			},
			{
				title: 'Пациент',
				url: '/patient/view/' + self.patientId
			}
		],
		current: 'Обследования'
	};

	self.sortFields = [];
	self.survey = {};

	var load = function () {
		systemSvc.getSurveyTypes().then(function(data) {
			self.surveyTypes = data;

			return patientSvc.getPatient(self.patientId);
		}).then(function(data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getSurveys(self.patientId);
		}).then(function(data) {
			self.surveys = data;

			angular.forEach(self.surveys, getSurvey);
		}, self.onLoadFailed);
	};

	load();

	var getSurvey = function (survey) {
		angular.forEach(self.surveyTypes, function (type) {
			if (!survey.type && survey.typeId == type.id) {
				survey.type = type.value;
			}
		});
	};
	
	self.editFormEnabled = false;

	self.add = function () {
		self.editFormEnabled = true;
	};


	self.ok = function () {
		self.survey.patientId = self.patientId;
		patientSvc.storeSurvey(self.survey).then(function (data) {
			self.survey = {};
			load();
			self.editFormEnabled = false;
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		self.survey = {};
		self.editFormEnabled = false;
	};
}
