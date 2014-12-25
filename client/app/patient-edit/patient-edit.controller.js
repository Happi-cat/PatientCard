'use strict';

angular.module('dentalPatientCardApp')
  .controller('PatientEditCtrl', function ($scope, $routeParams, Auth, Patient) {
    var self = $scope;

	self.patientId = $routeParams.patientId;
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
		Patient.get({
			patientId: self.patientId,
			token: Auth.getToken(),
		}).then(function (data) {
			self.patient = data;

			var item = self.breadcrumb.items[1];
			item.title = data.displayName;

		}, self.onLoadFailed);
	};

	load();

	self.ok = function () {
		Patient.update({
			token: Auth.getToken()
		}, self.patient).then(function () {
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
