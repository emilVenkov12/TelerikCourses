function calcTrapezoidArea (inputBaseA, inputBaseB, inputAltitude) {
			var baseA = parseInt(inputBaseA);
			var baseB = parseFloat(inputBaseB);
			var altitude = parseInt(inputAltitude);

			if (inputBaseA == "" || inputBaseB == "" || inputAltitude == "") {
				alert('Enter numbers in the all text field!!');
			}
			else if(baseA == inputBaseA && baseB == inputBaseB
					&& altitude == inputAltitude){
				var area = ((baseA + baseB) / 2) * altitude;
				jsConsole.writeLine('The area of trapezoid is : ' + area);
				
			}									
			else if(baseA != inputBaseA){
				alert('\"' + inputBaseA + '\"' + ' is not a valid number!');
			}
			else if(baseB != inputBaseB){
				 alert('\"' + inputBaseB + '\"' + ' is not a valid number!');
			}
			else if(altitude != inputAltitude){
				alert('\"' + inputAltitude + '\"' + ' is not a valid number!');
			}
		}