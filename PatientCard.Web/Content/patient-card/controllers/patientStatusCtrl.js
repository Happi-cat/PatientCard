'use strict';

function PatientStatusCtrl($routeParams, patientSvc, ROLES) {
	PatientCtrl.call(this, $routeParams);

	var self = this;

	self.editPerm = {
		role: [ROLES.doctor, ROLES.admin]
	};

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
		current: 'Стоматологический статус'
	};	
	
	var load = function () {
		patientSvc.getPatient(self.patientId).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;
		}, self.onLoadFailed);
	};

	load();
}

function PatientDentistStatusCtrl($routeParams, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;

	var load = function () {
		patientSvc.getDentistStatuses(self.patientId).then(function (data) {
			self.dentistStatuses = data;
		}, self.onLoadFailed);
	};

	load();

	self.editFormEnabled = false;

	self.add = function() {
		self.editFormEnabled = true;
	};

	self.status = {};

	self.ok = function () {
		self.status.patientId = self.patientId;
		patientSvc.storeDentistStatus(self.status).then(function (data) {
			self.status = {};
			load();
			self.editFormEnabled = false;
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

function PatientOhisStatusCtrl($routeParams, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	var load = function () {
		patientSvc.getOhisStatuses(self.patientId).then(function (data) {
			self.ohisStatuses = data;
		}, self.onLoadFailed);
	};

	load();
	
	self.editFormEnabled = false;
	
	self.add = function () {
		self.editFormEnabled = true;
	};
	
	self.status = {};

	self.ok = function () {
		self.status.patientId = self.patientId;
		patientSvc.storeOhisStatus(self.status).then(function (data) {
			self.status = {};
			load();
			self.editFormEnabled = false;
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

function PatientDfmStatusCtrl($routeParams, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	var load = function () {
		patientSvc.getDfmStatuses(self.patientId).then(function (data) {
			self.dfmStatuses = data;
		}, self.onLoadFailed);
	};

	load();
	
	self.editFormEnabled = false;
	
	self.add = function () {
		self.editFormEnabled = true;
	};
	
	self.status = {};

	self.ok = function () {
		self.status.patientId = self.patientId;
		patientSvc.storeDfmStatus(self.status).then(function (data) {
			self.status = {};
			load();
			self.editFormEnabled = false;
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

function PatientCpiStatusCtrl($routeParams, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	var load = function () {
		patientSvc.getCpiStatuses(self.patientId).then(function (data) {
			self.cpiStatuses = data;
		}, self.onLoadFailed);
	};

	load();
	
	self.editFormEnabled = false;
	
	self.add = function () {
		self.editFormEnabled = true;
	};
	
	self.status = {};

	self.ok = function () {
		self.status.patientId = self.patientId;
		patientSvc.storeCpiStatus(self.status).then(function (data) {
			self.status = {};
			load();
			self.editFormEnabled = false;
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

