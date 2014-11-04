'use strict';

function PatientVisitCtrl($routeParams, $scope, patientSvc, ROLES) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	self.editPerm = {
		role: [ROLES.doctor, ROLES.admin]
	};
	
	self.tablehead = [
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
		current: 'Дневник посещений'
	};

	self.sortFields = [];
	self.visit = {};

	var load = function () {
		patientSvc.getPatient(self.patientId).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getVisit(self.patientId);
		}).then(function (data) {
			self.visits = data;
		}, $scope.onLoadFailed);
	};

	load();

	self.editFormEnabled = false;

	self.add = function () {
		self.editFormEnabled = true;
	};


	self.ok = function () {
		self.visit.patientId = self.patientId;
		patientSvc.storeVisit(self.visit).then(function (data) {
			self.visit = {};
			load();
			self.editFormEnabled = false;
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		self.visit = {};
		self.editFormEnabled = false;
	};
}
