'use strict';

module.exports = {
    table: 'surveys',
    fields: {
        id: {
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
            validation: {
                length: {
                    maximum: 100
                },
                required: true,
            }
        },
        updatedBy: {
            column: 'updated_by',
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
    }
}