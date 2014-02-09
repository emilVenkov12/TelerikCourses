function onUseTestFuncBtnClick() {

	var arr = [1,2,1,4,1,3,4,1,111,3,2,1,"1"];	
	jsConsole.writeLine("Deep copy demo with array.");
	jsConsole.writeLine("Test array is: " + arr.join(", "));
	var newArr = clone(arr);

	jsConsole.writeLine("arr[2] = 129;");

	arr[2] = 129;

	jsConsole.writeLine("New array is: " + newArr.join(", "));
	jsConsole.writeLine("Test array is: " + arr.join(", "));

} 
function clone (obj) {
	if (obj == null || typeof obj != "object") {
		return obj;
	};
	
	if (obj instanceof Array) {
		newObj = [];
		for (var i = 0; i < obj.length; i++) {
			newObj[i] = clone(obj[i]);
		};
		return newObj;
	};

	if (obj instanceof Object) {
		newObj = {};
		for (var attr in obj) {
			if (obj.hasOwnProperty(attr)) {
				newObj[attr] = clone(obj[attr]);
			};
		};
		 return newObj;
	};
	throw new Error("Unable to clone given format!");
}