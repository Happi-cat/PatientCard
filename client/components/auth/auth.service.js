'use strict';

angular.module('dentalPatientCardApp')
	.factory('Auth', function Auth($location, $rootScope, $http, User, $cookieStore, $q) {
		var self = {};

		var currentUser = {};
		if ($cookieStore.get('token')) {
			currentUser = User.get();
		}

		/**
		 * Authenticate user and save token
		 *
		 * @param  {Object}   user     - login info
		 * @param  {Function} callback - optional
		 * @return {Promise}
		 */
		self.login = function(user, callback) {
			var cb = callback || angular.noop;
			var deferred = $q.defer();

			$http.post('/auth/local', {
				username: user.username,
				password: user.password
			}).
			success(function(data) {
				$cookieStore.put('token', data.token);
				currentUser = User.get();
				deferred.resolve(data);
				return cb();
			}).
			error(function(err) {
				self.logout();
				deferred.reject(err);
				return cb(err);
			});

			return deferred.promise;
		};

		/**
		 * Delete access token and user info
		 *
		 * @param  {Function}
		 */
		self.logout = function() {
			$cookieStore.remove('token');
			currentUser = {};
		};


		/**
		 * Gets all available info on authenticated user
		 *
		 * @return {Object} user
		 */
		self.getCurrentUser = function() {
			return currentUser;
		};

		/**
		 * Check if a user is logged in
		 *
		 * @return {Boolean}
		 */
		self.isLoggedIn = function() {
			return !!currentUser.username;
		};

		/**
		 * Check if a user is an admin
		 *
		 * @return {Boolean}
		 */
		self.isAdmin = function() {
			return currentUser.role === 'administrator';
		};

		self.isInRole = function(roles) {
			if (roles === true) {
				return self.isLoggedIn();
			}
			if (angular.isString(roles)) {
				return currentUser.role === roles;
			}
			if (angular.isArray(roles)) {
				for(var role in roles) {
					if (currentUser.role === role) {
						return true;
					}
				}
			}
			return false;
		};

		/**
		 * Get auth token
		 */
		self.getToken = function() {
			return $cookieStore.get('token');
		};

		return self;
	}).run(function ($rootScope, $location, Auth, URLS) {
		// Check perm before page change
		$rootScope.$on('$routeChangeStart', function (event, currRoute) {
			if (!Auth.isInRole(currRoute.auth)) {
				$location.path(URLS.login);
			}
		});
	});