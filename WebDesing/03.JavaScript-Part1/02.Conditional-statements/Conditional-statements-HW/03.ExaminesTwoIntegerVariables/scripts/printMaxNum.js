function printMaxNum (inputFirstNum, inputSecondNum, inputThirdNum) {			
			var firstNum = parseInt(inputFirstNum);
			var secondNum = parseInt(inputSecondNum);
			var thirdNum = parseInt(inputThirdNum);

			if (inputFirstNum == "" || inputSecondNum == "" || inputThirdNum == "") {
				alert('Fill all text fields!');
				return;
			};
			if(firstNum == inputFirstNum 
				&& secondNum == inputSecondNum && thirdNum == inputThirdNum){
				var max = 0;
				if (firstNum > secondNum) {
					if (firstNum > thirdNum) {
						max = firstNum;
					} 
					else{
						max = thirdNum;
					};
				} 
				else{
					if (secondNum > thirdNum) {
						max = secondNum;
					} 
					else{
						max = thirdNum;
					};	
				};
				jsConsole.writeLine('Max = ' + max);
			}							
			else if(firstNum != inputFirstNum){
				alert(inputFirstNum + ' is not a valid integer number!');
			}
			else if(secondNum != inputSecondNum){
				alert(inputSecondNum + ' is not a valid integer number!');
			}
			else if(thirdNum != inputThirdNum){
				alert(inputThirdNum + ' is not a valid integer number!');
			}
		}