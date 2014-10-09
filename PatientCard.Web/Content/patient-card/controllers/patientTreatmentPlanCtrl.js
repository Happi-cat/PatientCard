'use strict';

function PatientTreatmentPlanCtrl($routeParams, $scope, patientSvc, systemSvc, ROLES) {
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
		current: 'План лечения'
	};

	var options = [];
	var load = function () {
		systemSvc.getTreatmentOptions().then(function (data) {
			options = data;

			return patientSvc.getPatient(self.patientId);
		}).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getTreatmentPlan(self.patientId);
		}).then(function (data) {
			self.treatmentPlan = data;
			if (!self.treatmentPlan) {
				self.treatmentPlan = [];
			}

			angular.forEach(options, getPlan);
		}, self.onLoadFailed);
	};

	load();

	var getPlan = function (option) {
		var plan = null;
		angular.forEach(self.treatmentPlan, function (item) {
			if (!plan && option.id == item.treatmentOptionId) {
				plan = item;
			}
		});

		if (!plan) {
			plan = { treatmentOptionId: option.id, patientId: self.patientId };
			self.treatmentPlan.push(plan);
		}
		plan.name = option.name;
		plan.order = option.order;
		plan.group = option.group;
	};

	self.ok = function () {
		patientSvc.storeTreatmentPlan(self.treatmentPlan).then(function (data) {
			$scope.goUp(self.breadcrumb);
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		$scope.goUp(self.breadcrumb);
	};
}
