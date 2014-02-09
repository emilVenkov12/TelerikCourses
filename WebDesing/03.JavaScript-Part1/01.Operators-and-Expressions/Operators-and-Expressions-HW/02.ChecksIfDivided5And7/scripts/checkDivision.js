function checkNumber (inputNum) {
			var number = parseInt(inputNum);
			if (input == "") {
				alert('Enter number in the text field!!');
			} 
			else if(number == input){
				if (input % 35 == 0) {
					jsConsole.writeLine(input + " can be diveded by 7 and 5 at the same time.");
				}
				else {
					jsConsole.writeLine(input + " can't be diveded by 7 and 5 at the same time.");
				}
				var bit = number & 8;
				jsConsole.writeLine('The third bit of ' + number + ' is ' + bit);
			}
			else if(number != input){
				alert(input + ' is not a valid number!');
			}			
		}