'use strict';

describe('Directive: tableHead', function () {

  // load the directive's module and view
  beforeEach(module('patientCardApp'));
  beforeEach(module('components/table-head/table-head.html'));

  var element, scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
     scope.datasource = [{ 
      title: 'this is the tableHead directive'
    }];
    element = angular.element('<table-head datasource="datasource"></table-head>');
    element = $compile(element)(scope);
    scope.$apply();
    expect(element.text().trim()).toBe('this is the tableHead directive');
  }));
});