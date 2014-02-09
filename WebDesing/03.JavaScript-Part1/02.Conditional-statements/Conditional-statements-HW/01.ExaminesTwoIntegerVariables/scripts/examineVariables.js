function examineVariables (inputFirstNum, inputSecondNum) {
			var firstNum = parseInt(inputFirstNum);
			var secondNum = parseFloat(inputSecondNum);			

			if (inputFirstNum == "" || inputSecondNum == "") {
				alert('Enter numbers in the all text fields!!');
			}
			else if(firstNum.toString().length == inputFirstNum.length 
					&& secondNum.toString().length == inputSecondNum.length){
				if (firstNum > secondNum) {
					var buff = firstNum;
					firstNum = secondNum;
					secondNum = buff;
				};
				jsConsole.writeLine('firstNum = ' + firstNum + ' secondNum = ' + secondNum);
			}									
			else if(firstNum.toString().length == inputFirstNum.length){
				alert(inputFirstNum + ' is not a valid integer number!');
			}
			else if(secondNum.toString().length == inputSecondNum.length){
				alert(inputSecondNum + ' is not a valid integer number!');
			}
		}