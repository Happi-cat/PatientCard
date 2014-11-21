'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;


var patientVisitSchema = new Schema({
    table: 'visits',
    fields: {
        id: {
            notInsert: true,
            notUpdate: true,
            default: 0,
            validation: {
                number: true,
                required: true,
            }
        },
        patientId: {
            column: 'patient_id',
            validation: {
                number: true,
                required: true,
            }
        },
        description: {
            validation: {
                length: {
                    maximum: 4000
                },
            }
        },
        created: {
            notInsert: true,
            notUpdate: true,
            validation: {
                datetime: true,
                required: true,
            }
        },
        updated: {
            notInsert: true,
            notUpdate: true,
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

module.exports = easyModel.model('patientVisit', patientVisitSchema);