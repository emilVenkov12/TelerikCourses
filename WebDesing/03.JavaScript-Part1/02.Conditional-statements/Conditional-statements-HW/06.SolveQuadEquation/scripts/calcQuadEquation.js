function calcQuadEquation (inputCoefA, inputCoefB, inputCoefC) {			
			var coefA = parseInt(inputCoefA);
			var coefB = parseInt(inputCoefB);
			var coefC = parseInt(inputCoefC);

			if (inputCoefA == "" || inputCoefB == "" || inputCoefC == "") {
				alert('Eneter coeficients in all text fields!');
				return;
			};
			if(coefA == inputCoefA && coefB == inputCoefB 
				&& coefC == inputCoefC ){
				var D = (coefB * coefB) - 4 * coefA * coefC;
				if (D < 0){
            		jsConsole.writeLine("The equation does't have real rootes");
       			}
        		else if (D == 0){
            		jsConsole.writeLine("The equations have double roots: x1 = x2 = " + (-coefB) / (2 * coefA));
        		}
        		else if (D > 0){
            		jsConsole.writeLine("The rootes are : x1 = " + (-coefB + Math.sqrt(D)) / (2 * coefA) + 
            			"; x2 = " + ((-coefB) - Math.sqrt(D)) / (2 * coefA));
        		}
			}							
			else if(coefA != inputCoefA){
				alert('\"' + inputCoefA + '\"' + ' is not a valid integer number!');
			}							
			else if(coefB != inputCoefB){
				alert('\"' + inputCoefB + '\"' + ' is not a valid integer number!');
			}							
			else if(coefC != inputCoefC){
				alert('\"' + inputCoefC + '\"' + ' is not a valid integer number!');
			}
		}