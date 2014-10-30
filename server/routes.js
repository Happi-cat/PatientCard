/**
 * Main application routes
 */

'use strict';

var errors = require('./components/errors');

module.exports = function(app) {

  app.param('patientId', function(req, res, next, id){
    req.patientId = id;
    next();
  });

  // Insert routes below
  app.use('/api/static/survey-type', require('./api/static-survey-type'));
  app.use('/api/static/role', require('./api/static-role'));
  app.use('/api/static/first-survey-option', require('./api/static-first-survey-option'));
  app.use('/api/static/treatment-option', require('./api/static-treatment-option'));
  app.use('/api/user', require('./api/user'));
  app.use('/api/auth', require('./api/auth'));
  app.use('/api/patient', require('./api/patient'));
  app.use('/api/patient/:patientId/first-survey', require('./api/patient-first-survey'));
  app.use('/api/patient/:patientId/treatment-plan', require('./api/patient-treatment-plan'));
  app.use('/api/patient/:patientId/visit', require('./api/patient-visit'));
  app.use('/api/patient/:patientId/survey', require('./api/patient-survey'));
  app.use('/api/patient/:patientId/dentist-status', require('./api/patient-status-dentist'));
  app.use('/api/patient/:patientId/ohis-status', require('./api/patient-status-ohis'));
  app.use('/api/patient/:patientId/cpi-status', require('./api/patient-status-cpi'));
  app.use('/api/patient/:patientId/dfm-status', require('./api/patient-status-cpi'));
  
  // All undefined asset or api routes should return a 404
  app.route('/:url(api|auth|components|app|bower_components|assets)/*')
   .get(errors[404]);

  // All other routes should redirect to the index.html
  app.route('/*')
    .get(function(req, res) {
      res.sendfile(app.get('appPath') + '/index.html');
    });
};
