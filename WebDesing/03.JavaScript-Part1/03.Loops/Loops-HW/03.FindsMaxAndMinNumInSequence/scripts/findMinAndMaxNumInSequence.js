function findMinAndMaxNumInSequence() {
	var numbers = [18, 95, 12, 12, 0, 8123, 91, -1];
	var max = 0;
	var min = numbers[0];

	
	for (var i = 0; i < numbers.length; i++) {
		if (numbers[i] > max) {
			max = numbers[i];
		};
		if (numbers[i] < min) {
			min = numbers[i];
		};
	};

	//this is shortest way :)
	/*max = Math.max.apply(null, numbers); 
	min = Math.min.apply(null, numbers);*/

	jsConsole.writeLine("Max = " + max + ", min = " + min);
}