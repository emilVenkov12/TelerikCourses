function checkThirdBit (input) {
			var number = parseInt(input);
						
			if (input == "") {
				alert('Enter number in the text field!!');
			} 
			else if(number == input){
				var bit = number & 8;
				jsConsole.writeLine('The third bit of ' + number + ' is ' + bit);
			}
			else if(number != input){
				alert(input + ' is not a valid number!');
			}
		}