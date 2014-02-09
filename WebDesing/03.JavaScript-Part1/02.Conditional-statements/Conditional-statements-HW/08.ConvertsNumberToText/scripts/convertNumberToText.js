function convertNumberToText (inputNum) {			
			var number = parseInt(inputNum);

			if (inputNum == "") {
				alert('Eneter number in the text field!');
				return;
			};
			if(number == inputNum){
				if (number < 0 || number > 999) {
					alert('Eneter number in the correct range !');
					return;
				};
				if (number == 0) {
					jsConsole.writeLine('Zero');
					return;
				};
				var numbers = ["", "One", "Two", "Three", "Four", "Five",
					"Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
					"Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
					"Eighteen", "Nineteen"];
				var tens = ["", "", "Twenty", "Thirty", "Forty", "Fifty",
					"Sixty", "Seventy", "Eighty", "Ninety"];
				var output = "";
				if (number > 99) {
					output += numbers[parseInt(inputNum[0])] + " hundred";
					if (number % 100 < 19 && number % 100 != '0' || 
						(inputNum[inputNum.length - 1] == '0' && inputNum[inputNum.length - 2] != '0')) {
						output += " and";
					};
				};
				if (number % 100 > 19) {
					output += " " + tens[parseInt(inputNum[inputNum.length  - 2])];					
				};
				if (number % 100 <= 19 && number % 100 > 9) {
					var index = parseInt(inputNum[inputNum.length  - 2]) * 10 + parseInt(inputNum[inputNum.length  - 1]);					
					output += " " + numbers[index];					
				};
				if (number % 100 < 10 || 
					(inputNum[inputNum.length  - 1] != '0' && inputNum[inputNum.length  - 2] != '1')) {
					var index = parseInt(inputNum[inputNum.length  - 1]);					
					output += " " + numbers[index];
				};

				jsConsole.writeLine(output);

			}							
			else if(number != inputNum){
				alert(inputFirstNum + ' is not a valid integer number!');
			}
		}