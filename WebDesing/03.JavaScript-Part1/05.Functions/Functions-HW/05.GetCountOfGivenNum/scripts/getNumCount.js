function onGetCountBtnClick() {
	var number = parseInt(document.getElementById("inputNumber").value);
	var strArray = document.getElementById("inputArray").value;
	if (isNaN(number)) {
		alert("Enter valid number!");
		return;
	};
	if (strArray == "") {
		alert('Enter a numbers for test!');
		return;
	};
	var arr = parseArray(strArray, ",");
	var numberCount = getApereansCount(arr, number);
	jsConsole.writeLine("The count of the given number is " + numberCount);

}
function getApereansCount(arr, number){
	var count = 0;
	var numberIndex = arr.indexOf(number);
	if (numberIndex != -1) {
		count++;
		numberIndex = arr.indexOf(number, numberIndex + 1);
		while(numberIndex != -1){
			count++;
			numberIndex = arr.indexOf(number, numberIndex + 1);
		};	
	};
	return count;
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
	var testNum = 5;
	jsConsole.write("Test array is: " + testArr.join(", "));
	printArrOnConsole(testArr);
	jsConsole.writeLine(" Test number is " + testNum);
	jsConsole.write("Result : " + getApereansCount(testArr, testNum)	);

}