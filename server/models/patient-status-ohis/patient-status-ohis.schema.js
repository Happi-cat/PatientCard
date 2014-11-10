'use strict';

module.exports = {
    table: 'ohis_statuses',
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
        cis1: {
            validation: {
                number: true,
                required: function() {
                    return !!this.dis1;
                }
            }
        },
        cis2: {
            validation: {
                number: true,
                required: function() {
                    return !!this.dis2;
                }
            }
        },
        cis3: {
            validation: {
                number: true,
                required: function() {
                    return !!this.dis3;
                }
            }
        },
        cis4: {
            validation: {
                number: true,
                required: function() {
                    return !!this.dis4;
                }
            }
        },
        cis5: {
            validation: {
                number: true,
                required: function() {
                    return !!this.dis5;
                }
            }
        },
        cis6: {
            validation: {
                number: true,
                required: function() {
                    return !!this.dis6;
                }
            }
        },
        dis1: {
            validation: {
                number: true,
                required: function() {
                    return !!this.cis1;
                }
            }
        },
        dis2: {
            validation: {
                number: true,
                required: function() {
                    return !!this.cis2;
                }
            }
        },
        dis3: {
            validation: {
                number: true,
                required: function() {
                    return !!this.cis3;
                }
            }
        },
        dis4: {
            validation: {
                number: true,
                required: function() {
                    return !!this.cis4;
                }
            }
        },
        dis5: {
            validation: {
                number: true,
                required: function() {
                    return !!this.cis5;
                },
            }
        },
        dis6: {
            validation: {
                number: true,
                required: function() {
                    return !!this.cis6;
                },
            }
        },
        ohis: {
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