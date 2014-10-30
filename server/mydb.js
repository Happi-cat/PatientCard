'use strict';

var connection  = require('express-myconnection'); 
var mysql = require('mysql');

module.exports = function(app, config) {
	app.use(connection(mysql, config.mysql, 'request'));
};