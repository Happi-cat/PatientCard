'use strict';

var _ = require('lodash');

function cpiFormula() {
    /*jshint validthis:true */
    
    var cpiSum = 0;
    var cpiCount = 0;

    for (var i = 1; i <= 6; i++) {
        var val = this['value' + i];

        val = (val !== null && val !== undefined) ? +val : -1;

        if (val >= 0 && val <=5) {
            cpiSum += val;
            cpiCount++;
        }
    }

    return cpiSum / cpiCount;
}

module.exports = {
    table: 'cpi_statuses',
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
        value1: {
        	validation: {
        		number: true,
                range: [0, 5],
        	}
        },
        value2: {
        	validation: {
        		number: true,
                range: [0, 5],
        	}
        },
        value3: {
        	validation: {
        		number: true,
                range: [0, 5],
        	}
        },
        value4: {
        	validation: {
        		number: true,
                range: [0, 5],
        	}
        },
        value5: {
        	validation: {
        		number: true,
                range: [0, 5],
        	}
        },
        value6: {
        	validation: {
        		number: true,
                range: [0, 5],
        	}
        },
        cpi: {
            formula: cpiFormula,
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
            validation:{
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