'use strict';

function PatientFirstSurveyCtrl($routeParams, $scope, patientSvc, systemSvc, ROLES) {
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
		current: 'Первичный осмотр'
	};

	var options = [];
	var load = function () {
		systemSvc.getFirstSurveyOptions().then(function (data) {
			options = data;

			return patientSvc.getPatient(self.patientId);
		}).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

			return patientSvc.getFirstSurvey(self.patientId);
		}).then(function (data) {
			self.firstSurvey = data;
			if (!self.firstSurvey) {
				self.firstSurvey = {
					patientId: self.patientId
				};
			}
			if (!self.firstSurvey.details) {
				self.firstSurvey.details = [];
			}

			angular.forEach(options, getDetail);
		}, $scope.onLoadFailed);
	};

	load();
	
	var getDetail = function (option) {
		var detail = null;
		angular.forEach(self.firstSurvey.details, function (item) {
			if (!detail && option.id == item.surveyOptionId) {
				detail = item;
			}
		});

		if (!detail) {
			detail = { surveyOptionId: option.id, patientId: self.patientId };
			self.firstSurvey.details.push(detail);
		}
		detail.value = option.value;
	};

	self.ok = function () {
		self.firstSurvey.patientId = self.patientId;
		patientSvc.storeFirstSurvey(self.firstSurvey).then(function (data) {
			$scope.goUp(self.breadcrumb);
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		$scope.goUp(self.breadcrumb);
	};
}