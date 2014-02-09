function onReverseWordBtnClick() {
	var word = document.getElementById("input-word").value;
	jsConsole.writeLine(reverseString(word));
	
}
function reverseString (str) {
	var reversedStr = [];
	for (var i = str.length - 1; i >= 0; i--) {
		reversedStr.push(str.charAt(i));
	};
	return reversedStr.join("");
}