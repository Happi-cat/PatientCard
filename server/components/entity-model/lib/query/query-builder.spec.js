'use strict';

var _ = require('lodash');
var should = require('should');
var query = require('./query-builder');

describe('Query Builder', function() {
	var table = 't';
	var maps = {
		select: {
			a: 'a',
			b: 'b',
			c: 'd',
		},
		insert: {
			a: 'a',
			c: 'd',
		},
		update: {
			b: 'b',
			c: 'd',
		}
	};
	var obj = {
		a: 1,
		b: 2,
		c: 3,
	};
	var key = {
		b: 1,
	};

	it('should generate select query', function () {
		query(maps).select().columns().from(table).compile()
			.should.be.eql('SELECT `a`, `b`, `d` AS `c` FROM t');

		query(maps).select().columns().from(table).where({ x: 1, y: 2, z: 3 }).compile()
			.should.be.eql('SELECT `a`, `b`, `d` AS `c` FROM t');

		query(maps).select().columns().from(table).limit(1).compile()
			.should.be.eql('SELECT `a`, `b`, `d` AS `c` FROM t  LIMIT 1');

		query(maps).select().columns().from(table).where({ a: 1 }).compile()
			.should.be.eql('SELECT `a`, `b`, `d` AS `c` FROM t WHERE `a` = 1');

		query(maps).select().columns().from(table).where({ a: 1, c: 2 }).compile()
			.should.be.eql('SELECT `a`, `b`, `d` AS `c` FROM t WHERE `a` = 1 AND `d` = 2');
	});

	it('should generate insert query', function () {
		query(maps).insert().into(table).values(obj).compile()
			.should.be.eql('INSERT INTO t ( `a`, `d` ) VALUES ( 1, 3 )');
	});

	it('should generate update query', function () {
		query(maps).update().table(table).set(obj, true).compile()
			.should.be.eql('UPDATE t SET `b` = 2, `d` = 3');

		query(maps).update().table(table).set(key, true).compile()
			.should.be.eql('UPDATE t SET `b` = 1, `d` = NULL');

		query(maps).update().table(table).set(key).compile()
			.should.be.eql('UPDATE t SET `b` = 1');
	});

	it('should generate delete query', function () {
		query(maps).delete().from(table).compile()
			.should.be.eql('DELETE FROM t');

		query(maps).delete().from(table).where({ x: 1, y: 2, z: 3 }).compile()
			.should.be.eql('DELETE FROM t');

		query(maps).delete().from(table).where({ a: 1 }).compile()
			.should.be.eql('DELETE FROM t WHERE `a` = 1');

	});
});