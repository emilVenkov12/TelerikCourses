function onUseTestFuncBtnClick() {
	jsConsole.writeLine("Get distance between 2 point demo:");
	var testPointOne = buildPoint(1, 1);
	var testPointTwo = buildPoint(2, 2);

	jsConsole.writeLine("First point = " + testPointOne.toString());
	jsConsole.writeLine("Second point = " + testPointTwo.toString());
	jsConsole.writeLine("Distance : " 
		+ getPointDistance(testPointOne, testPointTwo));


	jsConsole.writeLine("Check if three lines can make triangle:");
	var testLineOne = buildLine(buildPoint(1, 1), buildPoint(3,3));
	var testLineTwo = buildLine(buildPoint(3, 3), buildPoint(1,3));
	var testLineThree = buildLine(buildPoint(1, 3), buildPoint(1,1));

	jsConsole.writeLine("First line coords = " + testLineOne.toString());
	jsConsole.writeLine("Second line coords = " + testLineTwo.toString());
	jsConsole.writeLine("Second line coords = " + testLineThree.toString());

	jsConsole.writeLine("Can they make triangle? : " 
		+ isLinesMakeTreangle(testLineOne, testLineTwo, testLineThree));
	
}
function getPointDistance (firstP, secP) {
	var dist = Math.sqrt((Math.pow(firstP.X - secP.X, 2)) 
		+ (Math.pow(firstP.Y - secP.Y, 2)));
	
	return Math.round(dist * 100) / 100;
}
function isLinesMakeTreangle(lineOne, lineTwo, lineThree){
	var lineOneLength = getPointDistance(lineOne.startP, lineOne.endP);
	var lineTwoLength = getPointDistance(lineTwo.startP, lineTwo.endP);
	var lineThreeLength = getPointDistance(lineThree.startP, lineThree.endP);

	if ((lineOneLength < lineTwoLength + lineThreeLength) &&
		(lineTwoLength < lineOneLength + lineThreeLength) &&
		(lineThreeLength < lineTwoLength + lineOneLength)) {
		return true;
	};
	return false;
}
function buildPoint(xCoord, yCoord) {
	return {
		X : xCoord, 
		Y : yCoord,
		toString:function (){return "(" + this.X + ", " + this.Y + ")";}
	}
}
function buildLine (startPoint, endPoint) {
	return {
		startP : startPoint, 
		endP : endPoint,
		toString:function (){return this.startP + ", " + this.endP;}
	}	
}