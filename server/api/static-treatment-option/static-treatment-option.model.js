'use strict';

var easyModel = require('./../../components/easy-model');
var Schema = easyModel.Schema;


var staticTreatmentOptionSchema = new Schema({
    table: 'treatment_options',
    fields: {
        id: {
            validation: {
                number: true,
                required: true,
            }
        },
        name: {
            validation: {
                length: {
                    maximum: 200
                },
                required: true,
            }
        },
        isFillable: {
            column: 'is_fillable',
            validation: {
                bool: true,
                required: true,
            }
        },
        groupNumber: {
            column: 'group_number',
            validation: {
                number: true,
                required: true,
            }
        },
        orderNumber: {
            column: 'order_number',
            validation: {
                number: true,
            }
        },
    }
})

module.exports = easyModel.model('staticTreatmentOption', staticTreatmentOptionSchema);