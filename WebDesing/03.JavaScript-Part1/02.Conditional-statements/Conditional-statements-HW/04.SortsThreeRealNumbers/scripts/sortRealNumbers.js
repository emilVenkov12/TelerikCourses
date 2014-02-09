function sortRealNums (inputFirstNum, inputSecondNum, inputThirdNum) {			
			var firstNum = parseFloat(inputFirstNum);
			var secondNum = parseFloat(inputSecondNum);
			var thirdNum = parseFloat(inputThirdNum);

			if (inputFirstNum == "" || inputSecondNum == "" || inputThirdNum == "") {
				alert('Fill all text fields!');
				return;
			};
			if(firstNum == inputFirstNum 
				&& secondNum == inputSecondNum && thirdNum == inputThirdNum){
				var big = 0, bigger = 0, biggest = 0;

				if (firstNum > secondNum) {
					if (firstNum > thirdNum) {
						biggest = firstNum;
						if (secondNum > thirdNum) {
							bigger = secondNum;
							big = thirdNum;
						}
						else{
							bigger = thirdNum;
							big = secondNum;
						};
					} 
					else{
						biggest = thirdNum;
						bigger = firstNum;
						big = secondNum;
					};
				} 
				else{
					if (secondNum > thirdNum) {
						biggest = secondNum;
						if (firstNum > thirdNum) {
							bigger = firstNum;
							big = thirdNum;
						}
						else{
							bigger = thirdNum;
							big = firstNum;
						};
					} 
					else{
						biggest = thirdNum;
						big = firstNum;
						bigger = secondNum;
					};	
				};
				jsConsole.writeLine('Desceding: ' + biggest + ', ' + bigger + ', ' + big);
			}							
			else if(firstNum != inputFirstNum){
				alert(inputFirstNum + ' is not a valid float number!');
			}
			else if(secondNum != inputSecondNum){
				alert(inputSecondNum + ' is not a valid float number!');
			}
			else if(thirdNum != inputThirdNum){
				alert(inputThirdNum + ' is not a valid float number!');
			}
		}