function findLexSmallestAndLargestProp() {
	var smallestProp = "z";
	var largestProp = "";

	for(var prop in window){
		if (prop > largestProp) {
			largestProp = prop;
		};
		if (prop < smallestProp) {
			smallestProp = prop;
		};
	}

	jsConsole.writeLine("The smallest property in window is " + smallestProp);
	jsConsole.writeLine("The largest propertu in window is " + largestProp);
	jsConsole.writeLine();

	smallestProp = "z";
	largestProp = "";

	for(var prop in document){
		if (prop > largestProp) {
			largestProp = prop;
		};
		if (prop < smallestProp) {
			smallestProp = prop;
		};
	}

	jsConsole.writeLine("The smallest property in document is " + smallestProp);
	jsConsole.writeLine("The largest property in document is " + largestProp);
	jsConsole.writeLine();

	smallestProp = "z";
	largestProp = "";

	for(var prop in navigator){
		if (prop > largestProp) {
			largestProp = prop;
		};
		if (prop < smallestProp) {
			smallestProp = prop;
		};
	}

	jsConsole.writeLine("The smallest property in navigator is " + smallestProp);
	jsConsole.writeLine("The largest property in navigator is " + largestProp);
	jsConsole.writeLine();
}