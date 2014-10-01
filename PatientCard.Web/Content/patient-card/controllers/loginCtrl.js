'use strict';

function LoginCtrl($scope, $location, authSvc, URLS) {
	$scope.user = {};

	$scope.ok = function() {
		authSvc.login($scope.user.username, $scope.user.password).then(function(data) {
			$location.path(URLS.home);
		}, $scope.onLoadFailed);
	};
}

function LogoutCtrl($scope, $location, authSvc, URLS) {
	authSvc.logout().then(function() {
		$location.path(URLS.login);
	}, $scope.onLoadFailed);
}