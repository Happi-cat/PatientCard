'use strict';

function LandingCtrl($scope) {
	$scope.landing = [
		{
			icon: 'health-icon-nurse',
			title: 'Пациенты',
			description: 'Выберите данный пункт если хотите работать с существующими пациентами',
			url: '/patients'
		},
		{
			icon: 'health-icon-prescription',
			title: 'Добавить нового пациента',
			description: 'Выберите этот  пункт меню если хотите добавить нового пациента (заполнить карточку пациента)',
			url: '/patient/new'
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