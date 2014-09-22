'use strict';

function MenuCtrl() {
	this.actions = [];
	
}

MenuCtrl.prototype.registerLink = function(action) {
	this.actions.push(action);
};
