function printDigitName (inputDigit) {			
			var digit = parseInt(inputDigit);

			if (inputDigit == "") {
				alert('Eneter digit!');
				return;
			};
			if(digit == inputDigit){				
				if (digit > 9 || digit < 0) {
					alert(digit + ' is not a digit!');
					return;
				};
				var digitName;
				switch(digit)
				{
					case 0 : digitName = "zero";break;
					case 1 : digitName = "one";break;
					case 2 : digitName = "two";break;
					case 3 : digitName = "three";break;
					case 4 : digitName = "four";break;
					case 5 : digitName = "five";break;
					case 6 : digitName = "six";break;
					case 7 : digitName = "seven";break;
					case 8 : digitName = "eight";break;
					case 9 : digitName = "nine";break;
				}
				jsConsole.writeLine(digit + " --> " + digitName);
				//Another way to do same thing :)
				//var digitsNames = ["zero", "one", 
				//"two", "three", "four", "five", "six", "seven", "eight", "nine" ];
				//jsConsole.writeLine(digit + " --> " + digitsNames[digit]);

			}							
			else if(digit != inputDigit){
				alert('\"' + inputDigit + '\"' + ' is not a valid integer number!');
			}
		}