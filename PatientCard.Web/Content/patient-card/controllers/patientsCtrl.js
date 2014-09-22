'use strict';

function PatientsCtrl($scope, patientSvc) {
	var load = function() {
		patientSvc.getPatients().then(function(data) {

		}, function(error) {

		});
	};

	load();
}