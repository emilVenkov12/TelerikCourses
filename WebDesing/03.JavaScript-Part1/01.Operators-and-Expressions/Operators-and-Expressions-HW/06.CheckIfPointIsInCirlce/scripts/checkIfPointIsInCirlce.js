function checkIfPointIsInCirlce (inputX, inputY) {
			var pointX = parseInt(inputX);
			var pointY = parseInt(inputY);
			var circleX = 0;
			var circleY = 0;
			var circleRadius = 5; 
			if (inputY == "" || inputX == "") {
				alert('Enter numbers in both text fields!!');
			} 
			else if((pointX == inputX) && (pointY == inputY)){
				if (Math.sqrt(
						Math.pow(pointX - circleX, 2) + 
						Math.pow(pointX - circleX, 2)) <= circleRadius) 
				{
					jsConsole.writeLine("The point is in the circle.");
				}
				else
				{				
					jsConsole.writeLine("The point is not in the circle.");
				}				

			}
			else if(pointX != inputX){
				alert(inputX + ' is not a valid number!');
			}
			else if(pointY != inputY){
				alert(inputY + ' is not a valid number!');
			};
		}