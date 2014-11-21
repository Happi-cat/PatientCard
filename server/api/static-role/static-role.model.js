'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;


var staticRoleSchema = new Schema({
	table: 'roles',
	fields: {
		name: true,
		description: true,
	}
})

module.exports = easyModel.model('staticRole', staticRoleSchema);