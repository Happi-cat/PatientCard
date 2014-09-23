'use strict';

function PatientsCtrl($scope, patientSvc) {
	var self = {
		items: []
	};

	var load = function() {
		patientSvc.getPatients().then(function(data) {
			self.items = data;
		}, function(error) {
			console.log(error);
		});
	};

	load();

	return self;
}