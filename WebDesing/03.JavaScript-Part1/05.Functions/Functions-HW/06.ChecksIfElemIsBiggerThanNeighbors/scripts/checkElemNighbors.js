function onCheckNumberBtnClick() {
	var pos = parseInt(document.getElementById("inputPos").value);
	var strArray = document.getElementById("inputArray").value;
	
	if (strArray == "") {
		alert('Enter a numbers for test!');
		return;
	};

	var arr = parseArray(strArray, ",");

	if (isNaN(pos) || pos < 0 || pos >= arr.length) {
		alert("Enter valid pos!");
		return;
	};

	jsConsole.writeLine("Is number at position " + pos + " bigger than it's neighbors ? " + isElemBiggerThanNeibors(pos, arr));

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
	var testPos = 2	;
	jsConsole.write("Test array is: " + testArr.join(", "));

	jsConsole.writeLine(" Test position is " + testPos); 
	jsConsole.writeLine("Is number at position " + testPos + " bigger than it's neighbors ? " + isElemBiggerThanNeibors(testPos, testArr));

}