'use strict';

var mysql = require('mysql');
var connection  = require('express-myconnection'); 

module.exports = function(app, config) {
	app.use(connection(mysql, config.mysql, 'request'));
}