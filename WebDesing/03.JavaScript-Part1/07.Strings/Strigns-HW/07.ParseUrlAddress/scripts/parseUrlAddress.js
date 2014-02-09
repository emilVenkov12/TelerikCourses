function onParseUrlBtnClick(){
	var url = document.getElementById('input-url').value;

	var parsedUrl = parseUrlIntoObj(url);

	document.getElementById('output').innerHTML = parsedUrl;
}
function parseUrlIntoObj(url) {
	var regex = /(\w+):\/\/(.*?)(\/.*)/gi;

	var tokens = regex.exec(url);

	return{
		protoc: tokens[1],
		server: tokens[2],
		resource: tokens[3],
		toString:function (){
			return 'protocol: ' + this.protoc
			+ ', server: ' + this.server + ', resource ' + this.resource;}
	}

}