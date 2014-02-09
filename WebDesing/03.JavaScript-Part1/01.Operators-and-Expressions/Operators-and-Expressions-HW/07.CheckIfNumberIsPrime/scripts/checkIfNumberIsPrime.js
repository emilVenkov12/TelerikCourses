function checkIfNumberIsPrime (input) {
			var number = parseInt(input);
			if (input == "") {
				alert('Enter number in the text field!!');
			}
			else if(number == input){
				if (number < 100 && number > 0) {
					var divider = 2;
					var isPrime = true;
					while(divider <= Math.sqrt(number)){
						if (number % divider == 0) {
							isPrime = false;
							break;
						}
						else{
							divider++;
						};					
					}
					jsConsole.writeLine('Is ' + input + 'prime ? ' + isPrime);					
				} 
				else{
					alert(number + ' is not in correnct range([1..100])!');
				};			
			}									
			else if(number != input){
				alert('\"' + input + '\"' + ' is not a valid number!');
			}
		}