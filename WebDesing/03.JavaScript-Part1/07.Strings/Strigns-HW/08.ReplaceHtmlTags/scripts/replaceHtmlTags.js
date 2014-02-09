function onReplaceTagBtnClick(){
	var text = document.getElementById('input-text').value;

	document.getElementById('output').innerHTML = replaceATagWithUrl(text);
}
function replaceATagWithUrl(text) {
	var regex = /<a.*?href="(.*?)".*?>(.*?)<\/a>/gi;

	return text.replace(regex, "[URL=$1]$2[/URL]");
}
function onGenerateDemoBtnClick() {
	document.getElementById('input-text').value = 
	"<p>Please visit [URL=http://academy.telerik. com]our site[/URL]"+
	" to choose a training course."+
	"Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>";
}