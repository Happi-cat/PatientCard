'use strict';

module.exports = {
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