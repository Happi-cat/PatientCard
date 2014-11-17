'use strict';

var _ = require('lodash');

function cpiFormula() {
    /*jshint validthis:true */
    
    var cpiSum = 0;
    var cpiCount = 0;

    for (var i = 1; i <= 6; i++) {
        var val = this['value' + i];

        if (val >= 0 && val <=3) {
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
        	}
        },
        value2: {
        	validation: {
        		number: true,
        	}
        },
        value3: {
        	validation: {
        		number: true,
        	}
        },
        value4: {
        	validation: {
        		number: true,
        	}
        },
        value5: {
        	validation: {
        		number: true,
        	}
        },
        value6: {
        	validation: {
        		number: true,
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