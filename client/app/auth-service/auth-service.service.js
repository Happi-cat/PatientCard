'use strict';

angular.module('patientCardApp')
  .service('authService', function () {
    var self = this;

    self.isAuthenticated = function() {
      return true;
    };

    self.isAuthorized = function() {
      return true;
    };

    self.checkPerm = function (perm) {
      if (perm) {
        if (perm.role) {
          if (angular.isArray(perm.role)) {
            var flag = false;
            angular.forEach(perm.role, function (role) {
              if (!flag) {
                flag = self.isAuthorized(role);
              }
            });
            return flag;
          } else {
            return self.isAuthorized(perm.role);
          }
        }

        if (perm.authorized) {
          return self.isAuthenticated();
        }
      }
      return true;
    };
  });
