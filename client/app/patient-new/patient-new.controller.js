'use strict';

angular.module('dentalPatientCardApp')
  .controller('PatientNewCtrl', function ($scope, patientService) {
    var self = $scope;

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
		patientService.storePatient(self.patient).then(function () {
			$scope.goUp(self.breadcrumb);
		}, self.onSaveFailed);
	};

	self.cancel = function () {
		$scope.goUp(self.breadcrumb);
	};

	self.open = function ($event) {
		$event.preventDefault();
		$event.stopPropagation();

		self.opened = true;
	};

  });
