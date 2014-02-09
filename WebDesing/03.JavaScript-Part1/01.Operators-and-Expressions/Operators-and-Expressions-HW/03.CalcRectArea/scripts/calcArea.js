function calcArea (inputHeight, inputWidth) {
			var height = parseInt(inputHeight);
			var width = parseInt(inputWidth);

			if (inputHeight == "" || inputWidth == "") {
				alert('Enter numbers in both text fields!!');
				return;
			} 
			if (height == inputHeight && width == inputWidth){												
				jsConsole.writeLine("The rect area is : " + (width * height));
			}
			else if (width != inputWidth){
				jsConsole.writeLine('\"' + inputWidth + '\"');
			}
			else if (height != inputHeight){
				jsConsole.writeLine('\"' + inputHeight + '\"');
			}
		}