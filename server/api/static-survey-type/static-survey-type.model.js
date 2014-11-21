'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;


var staticSurveyTypeSchema = new Schema({
	table: 'survey_types',
	fields: {
		id: true,
		name: true,
	}
})

module.exports = easyModel.model('staticSurveyType', staticSurveyTypeSchema);