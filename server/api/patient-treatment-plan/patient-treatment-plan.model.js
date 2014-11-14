'use strict';

module.exports = {
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