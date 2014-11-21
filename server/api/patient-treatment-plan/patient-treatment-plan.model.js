'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;


var patientTreatmentPlanSchema = new Schema({
    table: 'treatment_plans',
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
        description: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        created: {
            validation: {
                datetime: true,
                required: true,
            }
        },
        updated: {
            validation: {
                datetime: true,
            }
        },
        createdBy: {
            column: 'created_by',
            notUpdate: true,
            validation: {
                length: {
                    maximum: 100
                },
                required: true,
            }
        },
        updatedBy: {
            column: 'updated_by',
            notInsert: true,
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
    }
})

module.exports = easyModel.model('patientTreatmentPlan', patientTreatmentPlanSchema);