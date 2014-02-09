function printNumsNotDivisibleBy3And7(inputNum) {			
			var number = parseInt(inputNum);

			if (inputNum == "") {
				alert('Enter number in the text field!');
				return;
			};
			if(number == inputNum){
				var answer = true;
				if (number < 1) {
					alert('Enter number bigger than zero!');
					return;
				};
				if (number > 7000) {
					answer = confirm("This may take a lot time to be print. " + 
						"Do you want to constinue ?");
				};
				if (answer) {
					var output = "";
					for (var i = 1; i <= number; i++) {
						if (i % 21 == 0) {
							output += (i + '<br>');
						};
					};
					if (output == "") {
						jsConsole.writeLine("There is no numbers in current" + 
							" interval which meet the given condition.");
					}
					else{ 	 	
						jsConsole.writeLine(output);	
					};
				};
			}							
			else if(number != inputNum){
				alert(inputNum + ' is not a valid integer number!');
			};
		}