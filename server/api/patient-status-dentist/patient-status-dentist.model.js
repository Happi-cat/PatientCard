'use strict';

module.exports = {
    table: 'dentist_statuses',
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