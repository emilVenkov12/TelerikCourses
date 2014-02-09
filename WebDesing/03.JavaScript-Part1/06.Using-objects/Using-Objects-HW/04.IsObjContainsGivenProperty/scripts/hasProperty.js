function onUseTestFuncBtnClick() {

	var arr = [1,2,1,4,1,3,4,1,111,3,2,1,"1"];	
	jsConsole.writeLine("Test array is: " + arr.join(", "));

	jsConsole.writeLine("Does array contains property lenght? " + hasProperty(arr, "length"));
}
function onCheckPropBtnClick() {
	var inputObj = document.getElementById('input-obj').value;
	var obj = eval("new "+inputObj + "()");		//eval() is very dengerous function!!, use it when you are read all about it!
	var prop = document.getElementById('input-prop').value;

	jsConsole.writeLine('Does ' + inputObj + " contains " + prop +"? " + hasProperty(obj, prop));
}
function Person() {
	this.firstName = "emo";
}
function hasProperty (obj, prop) {
	if (obj.hasOwnProperty(prop)) {
		return true;
	};
	return false;
}