'use strict';

angular.module('patient-card.auth')
	.constant('ROLES', {
		admin: 'Administrator',
		doctor: 'Doctor',
		nurse: 'Nurse'
	})
	.factory('authHttpInterceptor', function($q, $location, URLS) {
		return {
			'responseError': function(rejection) {
				if (rejection.status == 401 ||
					rejection.status == 403) {
					$location.path(URLS.login);
				}
				return $q.reject(rejection);
			}
		};
	})
	.service('authSvc', function($q, $http) {
		var self = this;
		self.status = {
			authorized: false,
			user: null
		};

		self.login = function(username, password) {
			var deferred = $q.defer();
			$http({ method: 'POST', url: '/api/account/login', data: { username: username, password: password } })
				.then(function(data) {
					if (data.data == 'null') {
						self.status.user = null;
					} else {
						self.status.user = data.data;
					}
					self.status.authorized = true;
					deferred.resolve(self.status.user);
				}, function(data) {
					deferred.reject({
						status: data.status,
						message: data.statusText,
					});
				});
			return deferred.promise;
		};


		self.logout = function() {
			var deferred = $q.defer();
			$http({ method: 'POST', url: '/api/account/logout', data: { username: self.status.user.username, password: self.status.user.password } })
				.then(function(data) {
					self.status.authorized = false;
					self.status.user = null;
					deferred.resolve();
				}, function(data) {
					deferred.reject({
						status: data.status,
						message: data.statusText,
					});
				});
			return deferred.promise;
		};

		self.isAuthenticated = function() {
			return self.status.authorized && self.status.user;
		};

		self.isAuthorized = function(role) {
			return self.status.authorized && self.status.user && self.status.user.job == role;
		};
	})
	.service('permSvc', function (authSvc) {
		var self = this;
		
		self.checkPerm = function (perm) {
			if (perm) {
				if (perm.role) {
					if (angular.isArray(perm.role)) {
						var flag = false;
						angular.forEach(perm.role, function (role) {
							if (!flag) {
								flag = authSvc.isAuthorized(role);
							}
						});
						return flag;
					} else {
						return authSvc.isAuthorized(perm.role);
					}
				}

				if (perm.authorized) {
					return authSvc.isAuthenticated();
				}
			}
			return true;
		};
	});