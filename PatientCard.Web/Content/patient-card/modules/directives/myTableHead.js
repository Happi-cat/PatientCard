'use strict';

angular.module('patient-card.directives')
	.directive('myTableHead', function() {
		return {
			restrict: 'A',
			scope: {
				tableHead: '=myTableHead',
				sortFields: '=mySortFields'
			},
			templateUrl: '/Widget/TableHeader',
			controller: TableHeadCtrl
		};
	});