'use strict';

module.exports = {
    table: 'first_surveys',
    fields: {
        patientId: {
            column: 'patient_id',
            validation: {
                number: true,
                required: true,
            }
        },
        reason: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        face: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        skin: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        limbs: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        bones: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
    }
}