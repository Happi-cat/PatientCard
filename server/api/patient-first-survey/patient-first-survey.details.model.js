'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;

var patientFirstSurveyDetailsSchema = new Schema({

    table: 'first_survey_details',
    fields: {
        patientId: {
            column: 'patient_id',
            validation: {
                number: true,
                required: true,
            }
        },
        optionId: {
            column: 'option_id',
            validation: {
                number: true,
                required: true,
            }
        },
        yesNo: {
            column: 'yes_no',
            default: false,
            validation: {
                bool: true,
                required: true,
            }
        },
        details: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
    }
})

module.exports = easyModel.model('patientFirstSurveyDetails', patientFirstSurveyDetailsSchema);