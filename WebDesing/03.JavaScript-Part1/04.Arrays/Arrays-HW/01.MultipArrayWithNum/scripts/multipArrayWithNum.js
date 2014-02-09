function multipArrayWith5() {			
			var numbers = new Array(20);

			var output = "";

			for (var i = 0; i < numbers.length; i++) {
				numbers[i] = i * 5;
				output += (numbers[i] + " ");
			};
			jsConsole.writeLine(output);
		}