'use strict';


module.exports = {
    table: 'cpi_statuses',
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