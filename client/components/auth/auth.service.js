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

		/**
		 * Get auth token
		 */
		self.getToken = function() {
			return $cookieStore.get('token');
		};

		return self;
	});