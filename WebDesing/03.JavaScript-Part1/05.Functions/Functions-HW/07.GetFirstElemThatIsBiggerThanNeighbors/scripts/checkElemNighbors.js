function onCheckNumberBtnClick() {

	var strArray = document.getElementById("inputArray").value;
	
	if (strArray == "") {
		alert('Enter a numbers for test!');
		return;
	};

	var arr = parseArray(strArray, ",");

	for (var i = 0; i < arr.length; i++) {
		if (isElemBiggerThanNeibors(i, arr)) {
			jsConsole.writeLine("First element bigger than it's neighbors is " + arr[i] +
				 " on position " + i);
			return;
		};
	};
	jsConsole.writeLine("Doesn't exist such element");

}
function isElemBiggerThanNeibors(pos, array){
		if ((pos == 0) || (pos == array.length - 1)){
			return false;
		}
		else if ((array[pos] > array[pos - 1]) &&
				(array[pos] > array[pos + 1])){
			return true;
		};
		return false;
}
function parseArray (strArray, separator) {
	var arr = strArray.split(separator);
	var intArr = new Array(arr.length);
	for (var i = 0; i < arr.length; i++) {
		intArr[i] = parseInt(arr[i]);
	};
	return intArr;
}
function onUseTestFuncBtnClick(){
	var testArr = [4,5,8,5,6,5,1,2,6,75,2,85,8,5];

	jsConsole.write("Test array is: " + testArr.join(", "));

	for (var i = 0; i < testArr.length; i++) {
		if (isElemBiggerThanNeibors(i, testArr)) {
			jsConsole.writeLine("</br> First element bigger than it's neighbors is " + testArr[i]);
			return;
		};
	};

}