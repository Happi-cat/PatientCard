'use strict';

angular.module('patient-card.auth')
	.service('permSvc', function ($rootScope, authSvc) {
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