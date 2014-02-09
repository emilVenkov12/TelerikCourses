function examineVariables (inputFirstNum, inputSecondNum, inputThirdNum) {
			var elemCount = 3;
			var numbers = new Array(elemCount);
			numbers[0] = parseInt(inputFirstNum);
			numbers[1] = parseInt(inputSecondNum);
			numbers[2] = parseInt(inputThirdNum);

			for (var i = 0; i < numbers.length; i++) {
				if (numbers[i] == "") {
					alert('Enter numbers in all text fields!');
					return;
				};
			};
			if(numbers[0] == inputFirstNum && numbers[1] == inputSecondNum && numbers[2] == inputThirdNum){
				var negativeCount = 0;
				var sing = "";
					for (var i = 0; i < numbers.length; i++) {
						if (numbers[i] < 0) {
							negativeCount++;
						};
					};	
					if (negativeCount % 2 == 1) {
						sign = 'minus';
					}
					else{
						sign = 'plus';
					};							
					jsConsole.writeLine('The sign of the product is ' + sign);
			}							
			else if(numbers[0] != inputFirstNum){
				alert(inputFirstNum + ' is not a valid integer number!');
			}
			else if(number[1] != inputSecondNum){
				alert(inputSecondNum + ' is not a valid integer number!');
			}
			else if(number[2] != inputThirdNum){
				alert(inputThirdNum + ' is not a valid integer number!');
			}
		}