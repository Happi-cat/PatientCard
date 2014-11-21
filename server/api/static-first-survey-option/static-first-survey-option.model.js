'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;


var staticFirstSurveyOptionSchema = new Schema({
	table: 'first_survey_options',
	fields: {
		id: true,
		name: true,
	}
})

module.exports = easyModel.model('staticFirstSurveyOption', staticFirstSurveyOptionSchema);