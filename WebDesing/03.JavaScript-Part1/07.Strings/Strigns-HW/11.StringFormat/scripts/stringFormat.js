function onUseDemoBtnClick(){

	var format = "{0}, {1}, {0} text {2} {3}";
	var str = stringFormat(format,1,"Pesho","Gosho");
	document.getElementById('output').innerHTML = str;
	
}
function stringFormat(format) {
	var text = format;
	for (var i = 1; i < arguments.length; i++) {
		var regex = new RegExp("\\{"+(i - 1)+"\\}","gi");

		text = text.replace(regex, arguments[i]);
	};
	return text;
}