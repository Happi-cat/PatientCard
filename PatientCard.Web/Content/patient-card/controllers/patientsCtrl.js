'use strict';

function PatientsCtrl($scope, patientSvc) {
	var self = {
		items: [{ firstName: 'test'}]
	};

	var load = function() {
		console.log('1');
		patientSvc.getPatients().then(function(data) {
			self.items = data;
			console.log(data);
		}, function(error) {

		});
	};

	load();

	return self;
}