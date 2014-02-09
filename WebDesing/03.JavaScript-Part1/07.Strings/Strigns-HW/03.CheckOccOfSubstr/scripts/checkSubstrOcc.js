function onCountSubstrBtnClick() {
	var text = document.getElementById("input-text").value;
	var substr = document.getElementById("input-substr").value;

	document.getElementById("output").innerHTML = 
		'Count of substring  ' + '"' + substr +'"' + ' is ' + getOccCount(text, substr);
	
}
function getOccCount (text, substr) {
	var unSenceText = text.toLowerCase();
	var count = 0;
	var pos = unSenceText.indexOf(substr);
 
	while ( pos != -1 ) {
	   count++;
	   pos = unSenceText.indexOf(substr, pos + 1);
	}
	return count;
}