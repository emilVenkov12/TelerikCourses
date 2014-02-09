function onGetDivCountBtnClick(){

	var divCount = document.getElementsByTagName("div").length;
	jsConsole.writeLine("The count of div elements in the body is: " 
		+ divCount + "\n");
}
function onAddDivBtnClick() {
	var divElem = document.createElement("div");
	document.body.appendChild(divElem);
}