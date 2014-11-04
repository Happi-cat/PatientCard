'use strict';

function PatientStatusCtrl($routeParams, $scope, patientSvc, ROLES) {
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
		}, $scope.onLoadFailed);
	};

	load();
}

function PatientDentistStatusCtrl($routeParams, $scope, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;

	var load = function () {
		patientSvc.getDentistStatuses(self.patientId).then(function (data) {
			self.dentistStatuses = data;
		}, $scope.onLoadFailed);
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
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

function PatientOhisStatusCtrl($routeParams, $scope, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	var load = function () {
		patientSvc.getOhisStatuses(self.patientId).then(function (data) {
			self.ohisStatuses = data;
		}, $scope.onLoadFailed);
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
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

function PatientDfmStatusCtrl($routeParams,  $scope, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	var load = function () {
		patientSvc.getDfmStatuses(self.patientId).then(function (data) {
			self.dfmStatuses = data;
		}, $scope.onLoadFailed);
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
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

function PatientCpiStatusCtrl($routeParams, $scope, patientSvc) {
	PatientCtrl.call(this, $routeParams);

	var self = this;
	
	var load = function () {
		patientSvc.getCpiStatuses(self.patientId).then(function (data) {
			self.cpiStatuses = data;
		}, $scope.onLoadFailed);
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
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		self.status = {};
		self.editFormEnabled = false;
	};
}

