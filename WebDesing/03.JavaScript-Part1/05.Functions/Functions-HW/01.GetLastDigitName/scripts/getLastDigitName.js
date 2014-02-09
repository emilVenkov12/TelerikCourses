function onGetDigitNameBtnClick() {
	var number = jsConsole.readFloat("#tb-number");
	if (isNaN(number)) {
		alert("Ivalid number!");
		return;
	};
	var digitName = getLastDigitName(number);
	jsConsole.writeLine("The name of the last digit is " + digitName);
}

function getLastDigitName(number) {
		var lastDigit = number % 10;
		var digitsNames = ["zero", "one", "two", "three", "four",
			"five", "six", "seven", "eight", "nine"];
		return digitsNames[lastDigit];
	}