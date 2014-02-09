function onParseCaseTagsBtnClick(){
	var text = document.getElementById("input-text").value;

	document.getElementById("input-text").value = parseCaseTags(text);
	
}
function parseCaseTags (text) {
	var regex = /<upcase>(.*?)<\/upcase>/gi;

	var parsedText = text.replace(regex,  function(a, b){
		return b.toUpperCase();
	});

	regex = /<lowcase>(.*?)<\/lowcase>/gi;	

	parsedText = parsedText.replace(regex,  function(a, b){
		return b.toLowerCase();
	});

	regex = /<mixcase>(.*?)<\/mixcase>/gi;
	return parsedText = parsedText.replace(regex,  function(a, b){
		var mixedCase = "";
		for (var i = 0; i < b.length; i++) {
			if(Math.floor(Math.random() * 100) % 2 == 0){
				mixedCase += b.charAt(i).toLowerCase();
			}
			else{
				mixedCase += b.charAt(i).toUpperCase();	
			};

		};
		return mixedCase;
	});

}