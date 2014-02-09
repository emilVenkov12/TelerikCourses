function onUseTestFuncBtnClick() {

	var arr = [1,2,1,4,1,3,4,1,111,3,2,1,"1"];	
	jsConsole.writeLine("Test array is: " + arr.join(", "));
	arr.remove(1);
	jsConsole.writeLine("Result after removing 1: " + arr.join(", "));
	jsConsole.writeLine("Note: The last element is not removed because is not a number.");

}

Array.prototype.remove = function(elemToRemove) {
	for (var i = 0; i < this.length; i++) {
		if (this[i] === elemToRemove) {
			this.splice(i, 1);
			i--;
		};
	};
};