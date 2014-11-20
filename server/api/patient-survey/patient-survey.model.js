'use strict';

module.exports = {
    table: 'surveys',
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
        typeId: {
            column: 'type_id',
            validation: {
                number: true,
            }
        },
        description: {
            validation: {
                length: {
                    maximum: 1000
                },
            }
        },
        xrayDose: {
            column: 'xray_dose',
            validation: {
                number: true,
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
}