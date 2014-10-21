'use strict';

angular.module('patientCardApp')
  .controller('PatientEditCtrl', function ($scope, $routeParams, patientService) {
    var self = $scope;

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
		patientService.getPatient(self.patientId).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

		}, self.onLoadFailed);
	};

	load();

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
