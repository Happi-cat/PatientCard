'use strict';

module.exports = {
    table: 'patients',
    fields: {
        id: {
            notInsert: true,
            notUpdate: true,
            validation: {
                number: true,
                required: true,
            }
        },
        firstName: {
            column: 'first_name',
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
        middleName: {
            column: 'middle_name',
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
        lastName: {
            column: 'last_name',
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
        birthDate: {
            column: 'birth_date',
            validation: {
                datetime: true,
                required: true,
            }
        },
        gender: {
            validation: {
                inclusion: ['male, female'],
                requierd: true,
            }
        },
        address: {
            validation: {
                length: {
                    maximum: 400
                },
                required: true,
            }
        },
        phone: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        socialStatus: {
            column: 'social_status',
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        job: {
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
    }
}