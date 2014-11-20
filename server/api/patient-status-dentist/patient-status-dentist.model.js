'use strict';

module.exports = {
    table: 'dentist_statuses',
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
        bite: {
            validation: {
                length: {
                    maximum: 1000
                },
            }
        },
        hardTissue: {
            column: 'hard_tissue',
            validation: {
                length: {
                    maximum: 1000
                },
            }
        },
        mucous: {
            validation: {
                length: {
                    maximum: 1000
                },
            }
        },
        xrayDiagnostics: {
            column: 'xray_diagnostics',
            validation: {
                length: {
                    maximum: 1000
                },
            }
        },
        preliminaryDiagnosis: {
            column: 'preliminary_diagnosis',
            validation: {
                length: {
                    maximum: 1000
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

}