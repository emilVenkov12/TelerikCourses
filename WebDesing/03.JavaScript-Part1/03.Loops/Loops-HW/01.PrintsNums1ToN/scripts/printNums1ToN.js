function printNums1ToN (inputNum) {			
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
				if (number > 5000) {
					answer = confirm("This may take a lot time to be print. " + 
						"Do you want to constinue ?");
				};
				if (answer) {
					var output = "";
					for (var i = 1; i <= number; i++) {
						output += (i + '<br>');
					};
					jsConsole.writeLine(output);	
				};
			}							
			else if(number != inputNum){
				alert(inputNum + ' is not a valid integer number!');
			};
		}