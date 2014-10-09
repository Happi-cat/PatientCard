'use strict';

function PatientCtrl($routeParams) {
	var self = this;
	
	self.patientId = $routeParams.id;
}