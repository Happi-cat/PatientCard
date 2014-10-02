'use strict';

function PatientStatusCtrl($scope, ROLES) {
	$scope.editPerm = {
		role: [ROLES.doctor, ROLES.admin]
	};

	$scope.breadcrumb = {
		items: [
			{
				title: 'Пациенты',
				url: '/patients'
			},
			{
				title: 'Пациент',
				url: '/patient/view/' + $scope.patientId
			}
		],
		current: 'Стоматологический статус'
	};	
	
	
	$scope.tablehead = [
		{
			name: 'created',
			title: 'Дата',
			sortable: true
		},
		{
			name: 'bite',
			title: 'Прикус'
		},
		{
			name: 'hardTissue',
			title: 'Состояние твердых тканей зубов, периодонта',
		},
		{
			name: 'mucous',
			title: 'Состояние слизистой оболочки рта',
		},
		{
			name: 'xrayDiagnostics',
			title: 'Данные рентгеновского и других исследований'
		},
		{
			name: 'preliminaryDiagnosis',
			title: 'Предварительный диагноз'
		}
	];

	$scope.cpiStatuses = [{
		
	}];
	
	$scope.dfmStatuses = [{

	}];
	
	$scope.ohisStatuses = [{

	}];
}