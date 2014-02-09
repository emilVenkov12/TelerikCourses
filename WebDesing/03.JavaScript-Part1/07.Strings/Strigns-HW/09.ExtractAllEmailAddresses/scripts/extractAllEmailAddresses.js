function onExtractBtnClick(){
	var text = document.getElementById('input-text').value;

	var allEmails = extractEmailAddresses(text);
	for (var i = 0; i < allEmails.length; i++) {
		document.getElementById('output').innerHTML += 
			allEmails[i] + "</br>";
	};
	
}
function extractEmailAddresses(text) {
	var regex = /([a-zA-Z0-9_\\-][\.a-zA-Z0-9_\\-]{3,49})@(([a-zA-Z0-9][a-zA-Z0-9\\-]{1,49})\.)+[a-zA-Z]{2,4}/gi;
	return text.match(regex);
}
function onGenerateDemoBtnClick() {
	document.getElementById('input-text').value = 
	"Please contact us by phone (+359 222 222 222) or by email at example@ab.bg"+
	"or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also:"+
	" @telerik.com. Neither this a@a.b.";
}