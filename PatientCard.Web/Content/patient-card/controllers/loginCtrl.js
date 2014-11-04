'use strict';

function LoginCtrl($location, $scope, authSvc, URLS) {
	var self = this;
	
	self.user = {};

	self.ok = function() {
		authSvc.login(self.user.username, self.user.password).then(function (data) {
			$location.path(URLS.home);
		}, $scope.onLoadFailed);
	};
}

function LogoutCtrl($location, $scope, authSvc, URLS) {
	var self = this;
	
	authSvc.logout().then(function() {
		$location.path(URLS.login);
	}, $scope.onLoadFailed);
}