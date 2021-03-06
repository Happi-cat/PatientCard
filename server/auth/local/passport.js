'use strict';

var passport = require('passport');
var LocalStrategy = require('passport-local').Strategy;

exports.setup = function(User, config) {
	passport.use(new LocalStrategy({
		passReqToCallback: true
	}, function(req, username, password, done) {
		User.findOne(req, {
			username: username
		}, function(err, user) {
			if (err) return done(err);

			if (!user) {
				return done(null, false, {
					message: 'This email is not registered.'
				});
			}
			if (user.password !== password) {
				return done(null, false, {
					message: 'This password is not correct.'
				});
			}
			return done(null, user);
		});
	}));
};