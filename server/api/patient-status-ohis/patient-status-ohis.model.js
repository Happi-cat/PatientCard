'use strict';

var _ = require('lodash');

function ohisFormula () {
    /*jshint validthis:true */

    var cisSum = 0;
    var cisCount = 0;
    var disSum = 0;
    var disCount = 0;

    for (var i = 1; i <= 6; i++) {
        var cis = this['cis' + i];
        var dis = this['dis' + i];

        cis = (cis !== null && cis !== undefined) ? +cis : -1;
        dis = (dis !== null && dis !== undefined) ? +dis : -1;

        if (cis >= 0 && cis <=3) {
            cisSum += cis;
            cisCount++;
        }
        if (dis >= 0 && dis <= 3) {
            disSum += dis;
            disCount++;
        }
    }

    return cisSum / cisCount + disSum / disCount;
}

module.exports = {
    table: 'ohis_statuses',
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
        cis1: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.dis1;
                }
            }
        },
        cis2: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.dis2;
                }
            }
        },
        cis3: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.dis3;
                }
            }
        },
        cis4: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.dis4;
                }
            }
        },
        cis5: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.dis5;
                }
            }
        },
        cis6: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.dis6;
                }
            }
        },
        dis1: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.cis1;
                }
            }
        },
        dis2: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.cis2;
                }
            }
        },
        dis3: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.cis3;
                }
            }
        },
        dis4: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.cis4;
                }
            }
        },
        dis5: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.cis5;
                },
            }
        },
        dis6: {
            validation: {
                number: true,
                range: [0, 3],
                required: function() {
                    return !!this.cis6;
                },
            }
        },
        ohis: {
            formula: ohisFormula,
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