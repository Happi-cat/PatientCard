'use strict';

function PatientEditCtrl($routeParams, $scope, patientSvc) {
	PatientCtrl.call(this, $routeParams);
	
	var self = this;

	self.patientId = $routeParams.id;
	self.edit = true;
	
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
		current: 'Редактирование'
	};
	self.gender = [
		{
			id: 'male',
			value: 'Муж.'
		},
		{
			id: 'female',
			value: 'Жен.'
		}
	];


	var load = function () {
		patientSvc.getPatient(self.patientId).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

		}, $scope.onLoadFailed);
	};

	load();

	self.ok = function () {
		patientSvc.storePatient(self.patient).then(function (data) {
			$scope.goUp(self.breadcrumb);
		}, $scope.onSaveFailed);
	};

	self.cancel = function () {
		$scope.goUp(self.breadcrumb);
	};

	self.open = function ($event) {
		$event.preventDefault();
		$event.stopPropagation();

		self.opened = true;
	};


}