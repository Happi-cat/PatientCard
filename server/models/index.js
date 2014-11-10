'use strict';

var model = require('./../components/express-model');

module.exports = function (app) {
	app.use(model('patient', require('./patient/patient.schema')));
	app.use(model('patientFirstSurvey', require('./patient-first-survey/patient-first-survey.schema')));
	app.use(model('patientStatusCpi', require('./patient-status-cpi/patient-status-cpi.schema')));
	app.use(model('patientStatusDentist', require('./patient-status-dentist/patient-status-dentist.schema')));
	app.use(model('patientStatusDfm', require('./patient-status-dfm/patient-status-dfm.schema')));
	app.use(model('patientStatusOhis', require('./patient-status-ohis/patient-status-ohis.schema')));
	app.use(model('patientSurvey', require('./patient-survey/patient-survey.schema')));
	app.use(model('patientTreatmentPlan', require('./patient-treatment-plan/patient-treatment-plan.schema')));
	app.use(model('patientVisit', require('./patient-visit/patient-visit.schema')));
	app.use(model('user', require('./user/user.schema')));
}