function checkPointPos (inputX, inputY) {
			var pointX = parseInt(inputX);
			var pointY = parseInt(inputY);

			if (inputX == "" || inputY == "") {
				alert('Enter numbers in the all text field!!');
			}
			else if(pointX == inputX && inputY == pointY){
				var rectLeftTopPtX = 1,
		        rectLeftTopPtY = -1,
        		rectWidth = 6, rectHeight = 2;

        		var circleCenterX = 1,
        		circleCenterY = 1,
        		circleRadius = 3;

		        var isOutRect = false;

		        var distance = (Math.sqrt(
		                Math.pow((pointX - circleCenterX), 2) 
		                + Math.pow((pointY - circleCenterY), 2)));
		        if (
		            (pointY > rectLeftTopPtY) || (pointX < rectLeftTopPtX) || 
		                (pointY < rectLeftTopPtY + (rectHeight * -1)) || (pointX > rectLeftTopPtX + rectWidth))
		        {
		            isOutRect = true;
		        };
		        jsConsole.writeLine('Is point within cirlcle and out of rectagle ? ' + 
		        	((distance <= circleRadius) && (isOutRect == true) ? true : false));

				
			}									
			else if(pointX != inputX){
				alert('\"' + inputX + '\"' + ' is not a valid number!');
			}									
			else if(pointY != inputY){
				alert('\"' + inputY + '\"' + ' is not a valid number!');
			}
		}