function onExtractTextBtnClick(){
	var text = document.getElementById('input-text').value;

	document.getElementById('input-text').value = removeAllHtmlTags(text);
}
function removeAllHtmlTags(text) {
	var regex = /(<([^>]+)>)/gi;
	return text.replace(regex,"");
}
function onGenerateDemoBtnClick() {
	document.getElementById('input-text').value = 
	"<html><head><title>Sample site</title></head><body><div>text"+
	"<div>more text</div>and more...</div>in body</body></html>";
}