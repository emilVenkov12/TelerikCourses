function checkNumber () {
			var input = parseInt(document.getElementById('inputField').value);
			if (input % 2 == 0) {
				jsConsole.writeLine(input + " is even.");
			}
			else {
				jsConsole.writeLine(input + " is odd.");
			}
		}