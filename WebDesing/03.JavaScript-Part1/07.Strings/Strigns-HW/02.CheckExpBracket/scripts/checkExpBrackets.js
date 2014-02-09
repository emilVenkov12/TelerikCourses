function onCheckExpBtnClick() {
	var exp = document.getElementById("input-exp").value;
	jsConsole.writeLine("Is expression has valid brackets ? " + hasValidBrackets(exp));
	
}
function hasValidBrackets(exp) {
	var openBrackCount = 0;
	var closeBrackCount = 0;
	for (var i = 0; i < exp.length; i++) {
			if (exp.charAt(i) == '(') {
				openBrackCount++;
			}
			else if (exp.charAt(i) == ')') {
				closeBrackCount++;
			};
	};
	return (openBrackCount - closeBrackCount) == 0;
}