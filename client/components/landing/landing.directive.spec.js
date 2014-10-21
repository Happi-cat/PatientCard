'use strict';

describe('Directive: landing', function () {

  // load the directive's module and view
  beforeEach(module('patientCardApp'));
  beforeEach(module('components/landing/landing.html'));

  var element, scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    scope.datasource = [{ 
      title: 'this is the landing directive'
    }];
    element = angular.element('<landing datasource="datasource"></landing>');
    element = $compile(element)(scope);
    scope.$apply();
    expect(element.text().trim()).toBe('this is the landing directive');
  }));
});