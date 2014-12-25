'use strict';

describe('Directive: breadcrumb', function () {

  // load the directive's module and view
  beforeEach(module('dentalPatientCardApp'));
  beforeEach(module('components/breadcrumb/breadcrumb.html'));

  var element, scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    scope.datasource = {
      current: 'this is the breadcrumb directive'
    };
    element = angular.element('<breadcrumb datasource="datasource"></breadcrumb>');
    element = $compile(element)(scope);
    scope.$apply();
    expect(element.text().trim()).toBe('this is the breadcrumb directive');
  }));
});