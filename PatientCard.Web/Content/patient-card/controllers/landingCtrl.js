'use strict';

function LandingCtrl($scope) {
	$scope.items = [
		{
			icon: 'health-icon-nurse',
			title: 'Пациенты',
			description: 'Выберите данный пунк если хотите работать с пациентами и их учетными карточками',
			url: '/patients'
		},
		{
			icon: 'health-icon-onlinepharmacycheck',
			title: 'Справка',
			description: 'Если есть какие-то вопросы по использованию данного портала, то вы можете заглянуть в этот раздел',
			url: '/help'
		},
		{
			icon: 'health-icon-caduceus',
			title: 'О нас',
			description: 'Контактная информация',
			url: '/about'
		}
	];
}