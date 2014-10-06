'use strict';

function LandingCtrl($scope) {
	$scope.landing = [
		{
			icon: 'medical-service-icon-man410',
			title: 'Пациенты',
			description: 'Выберите данный пункт если хотите работать с существующими пациентами',
			url: '/patients'
		},
		{
			icon: 'medical-service-icon-clipboard64',
			title: 'Добавить нового пациента',
			description: 'Выберите этот  пункт меню если хотите добавить нового пациента (заполнить карточку пациента)',
			url: '/patient/new'
		},
		{
			icon: 'medical-service-icon-2444',
			title: 'Справка',
			description: 'Если есть какие-то вопросы по использованию данного портала, то вы можете заглянуть в этот раздел',
			url: '/help'
		},
		{
			icon: 'medical-service-icon-caduceus6',
			title: 'О нас',
			description: 'Контактная информация',
			url: '/about'
		}
	];
}