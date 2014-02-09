function onReplaceSpaceBtnClick(){
	var text = document.getElementById("input-text").value;

	document.getElementById("input-text").value = text.replace(/[\u00A0\u202F\u2060\uFEFF]/g, "&nbsp;");	
}