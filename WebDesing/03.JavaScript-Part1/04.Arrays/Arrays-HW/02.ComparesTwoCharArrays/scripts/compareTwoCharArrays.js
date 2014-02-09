function compareArrays(firstArr, secArr) {
			var isEqual = true;
	        if (firstArr.length == secArr.length)
	        {
	            for (var i = 0; i < firstArr.length; i++)
	            {
	                if (firstArr[i] != secArr[i])
	                {
	                    isEqual = false;
	                    break;
	                }
	            };
	            if (isEqual)
	            {
	                jsConsole.writeLine("The arrays are equal.");
	            }
	            else
	            {
	                console.writeLine("The arrays are not equal.");
	            };
	        }
	        else
	        {
	            jsConsole.writeLine("The arrays are not equal.");
	        };		

			jsConsole.writeLine(output);
		}