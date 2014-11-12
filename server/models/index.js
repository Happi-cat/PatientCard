'use strict';

var model = require('./../components/express-model');

module.exports = function (app) {
	app.use(model('patient', require('./patient')));
	app.use(model('patientFirstSurvey', require('./patient-first-survey')));
	app.use(model('patientStatusCpi', require('./patient-status-cpi')));
	app.use(model('patientStatusDentist', require('./patient-status-dentist')));
	app.use(model('patientStatusDfm', require('./patient-status-dfm')));
	app.use(model('patientStatusOhis', require('./patient-status-ohis')));
	app.use(model('patientSurvey', require('./patient-survey')));
	app.use(model('patientTreatmentPlan', require('./patient-treatment-plan')));
	app.use(model('patientVisit', require('./patient-visit')));
	app.use(model('user', require('./user')));
}