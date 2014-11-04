'use strict';


function PatientNewCtrl($location, $scope, patientSvc) {
	var self = this;

	self.breadcrumb = {
		items: [
			{
				title: 'Пациенты',
				url: '/patients'
			}
		],
		current: 'Новый пациент'
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