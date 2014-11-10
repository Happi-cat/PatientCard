'use strict';

module.exports = {
    table: 'dfm_statuses',
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
        upperLeft1: {
            column: 'upper_left1',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft2: {
            column: 'upper_left2',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft3: {
            column: 'upper_left3',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft4: {
            column: 'upper_left4',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft5: {
            column: 'upper_left5',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft6: {
            column: 'upper_left6',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft7: {
            column: 'upper_left7',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperLeft8: {
            column: 'upper_left8',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight1: {
            column: 'upper_right1',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight2: {
            column: 'upper_right2',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight3: {
            column: 'upper_right3',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight4: {
            column: 'upper_right4',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight5: {
            column: 'upper_right5',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight6: {
            column: 'upper_right6',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight7: {
            column: 'upper_right7',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        upperRight8: {
            column: 'upper_right8',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft1: {
            column: 'lower_left1',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft2: {
            column: 'lower_left2',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft3: {
            column: 'lower_left3',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft4: {
            column: 'lower_left4',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft5: {
            column: 'lower_left5',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft6: {
            column: 'lower_left6',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft7: {
            column: 'lower_left7',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerLeft8: {
            column: 'lower_left8',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight1: {
            column: 'lower_right1',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight2: {
            column: 'lower_right2',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight3: {
            column: 'lower_right3',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight4: {
            column: 'lower_right4',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight5: {
            column: 'lower_right5',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight6: {
            column: 'lower_right6',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight7: {
            column: 'lower_right7',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        lowerRight8: {
            column: 'lower_right8',
            validation: {
                format: "[0-8A-E]{1}"
            }
        },
        dfm: {
            validation: {
                number: true
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
                required: true,
                length: {
                    maximum: 100
                },
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