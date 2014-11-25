/**
 * Main application routes
 */

'use strict';

var errors = require('./components/errors');

module.exports = function(app) {

	app.param('patientId', function(req, res, next, id) {
		req.patientId = id;
		next();
	});

	// Insert routes below
	app.use('/api/static/survey-types', require('./api/static-survey-type'));
	app.use('/api/static/roles', require('./api/static-role'));
	app.use('/api/static/first-survey-options', require('./api/static-first-survey-option'));
	app.use('/api/static/treatment-options', require('./api/static-treatment-option'));
	app.use('/api/users', require('./api/user'));
	app.use('/api/patients', require('./api/patient'));
	app.use('/api/patients/:patientId/first-survey', require('./api/patient-first-survey'));
	app.use('/api/patients/:patientId/treatment-plan', require('./api/patient-treatment-plan'));
	app.use('/api/patients/:patientId/visits', require('./api/patient-visit'));
	app.use('/api/patients/:patientId/surveys', require('./api/patient-survey'));
	app.use('/api/patients/:patientId/status/dentist', require('./api/patient-status-dentist'));
	app.use('/api/patients/:patientId/status/ohis', require('./api/patient-status-ohis'));
	app.use('/api/patients/:patientId/status/cpi', require('./api/patient-status-cpi'));
	app.use('/api/patients/:patientId/status/dfm', require('./api/patient-status-dfm'));

	app.use('/auth', require('./auth'));

	// All undefined asset or api routes should return a 404
	app.route('/:url(api|auth|components|app|bower_components|assets)/*')
		.get(errors[404]);

	// All other routes should redirect to the index.html
	app.route('/*')
		.get(function(req, res) {
				res.sendfile(app.get('appPath') + '/index.html');
		});
};