function onReverseNumberBtnClick() {
	var number = jsConsole.readFloat("#tb-number");
	if (isNaN(number)) {
		alert("Ivalid number!");
		return;
	};
	var reversedNumber = reverseNumber(number);
	jsConsole.writeLine("Reversed digits : " + reversedNumber);
}

function reverseNumber(number) {
		var output = "";
		var strNum = number.toString();
		for (var i = strNum.length- 1; i >= 0; i--) {
			output += strNum[i];
		};

		return output;
	}