function checkThirdDigit (input) {
			var number = parseInt(input);

			if (input == "") {
				alert('Enter number in the text field!!');
			} 
			else if(number == input && number.toString().length > 3 ){

				if (input[input.length - 3] == '7') {
					jsConsole.writeLine("The third digit of " + number + " is 7");
				}
				else{
					jsConsole.writeLine("The third digit of " + number + " is not 7");
				};
			}
			else if(number != input){
				alert(input + ' is not a valid number!');
			}
			else if (number.toString().length < 4 ) {
				alert('The number is too short!');
			};				
		}