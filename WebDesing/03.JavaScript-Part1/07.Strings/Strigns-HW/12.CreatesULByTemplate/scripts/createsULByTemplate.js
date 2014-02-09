function onGenerateListBtnClick(){
	var people = [{name: "Peter", age: 90},
		{name: "Gosho", age: 19},
		{name: "Pesho", age: 21},
		{name: "Minka", age: 20},];
	var tmpl = document.getElementById("list-item").innerHTML;
	var peopleList = generateList(people, tmpl);
	document.getElementById("list-item").innerHTML = peopleList;
}
function generateList(array, template) {
	var result = "<ul>";
	for (var i = 0; i < array.length; i++) {
		var tempRow = template.replace(/-\{(.+?)\}-/gi, function (a, b) {
		return array[i][b]; }); 
		result += "<li>" + tempRow + "</li>";
	};
	return (result + "</ul>");
}