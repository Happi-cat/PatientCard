'use strict';

module.exports = {
    table: 'users',
    fields: {
        username: {
            validation: {
                length: {
                    maximum: 100
                },
                required: true,
            }
        },
        password: {
            validation: {
                length: {
                    maximum: 100
                },
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
        email: {
            validation: {
                email: true,
                length: {
                    maximum: 100
                },
            }
        },
        role: {
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
        created: {
            validation: {
                datetime: true,
                required: true,
            }
        },
        active: {
            validation: {
                required: true,
                bool: true,
            }
        },
        address: {
            validation: {
                length: {
                    maximum: 400
                },
            }
        },
        phone: {
            validation: {
                length: {
                    maximum: 100
                },
            }
        },
    }
}