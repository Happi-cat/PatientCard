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
    },
    details: {
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
    }
}