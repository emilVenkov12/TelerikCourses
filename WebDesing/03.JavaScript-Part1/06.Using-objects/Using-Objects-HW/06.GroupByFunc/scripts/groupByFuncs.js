function onUseTestFuncBtnClick() {
	var people = [buildPerson("Gosho", "Petrov", 31),
		buildPerson("Bay", "Ivan", 81),
		buildPerson("Bay", "Ivan2", 81),
		buildPerson("Grany", "Petrov", 81),
		buildPerson("Grany", "Yaga", 31),
		buildPerson("Grany", "Ivan", 150),];
	jsConsole.writeLine("People for test: </br>" + people.join("; ") + "</br>");

	var peopleGroupedByFName = group(people, "firstName");
	jsConsole.writeLine("Grouped by first name:");
	for (var groups in peopleGroupedByFName) {
		jsConsole.writeLine("Group :");
		for (var i = 0; i < peopleGroupedByFName[groups].length; i++) {
			jsConsole.writeLine("&nbsp&nbsp"+peopleGroupedByFName[groups][i]);
		};		
	};

	var peopleGroupedByLName = group(people, "lastName");
	jsConsole.writeLine("Grouped by last name:");
	for (var groups in peopleGroupedByLName) {
		jsConsole.writeLine("Group :");
		for (var i = 0; i < peopleGroupedByLName[groups].length; i++) {
			jsConsole.writeLine("&nbsp&nbsp"+peopleGroupedByLName[groups][i]);
		};		
	};

	var peopleGroupedByAge = group(people, "age");
	jsConsole.writeLine("Grouped by age:");
	for (var groups in peopleGroupedByAge) {
		jsConsole.writeLine("Group :");
		for (var i = 0; i < peopleGroupedByAge[groups].length; i++) {
			jsConsole.writeLine("&nbsp&nbsp"+peopleGroupedByAge[groups][i]);
		};		
	};
}
function group (arr, groupBy) {
	var groupedElems = {};
  	for (var i = 0; i < arr.length; i++) {
   		if (groupedElems[arr[i][groupBy]]){
   			groupedElems[arr[i][groupBy]].push(arr[i]);
   		}
    	else{
			groupedElems[arr[i][groupBy]] = [arr[i]];
    	};     	
  	}
  return groupedElems;
}
function buildPerson (fName, lName, age) {
	return {
		firstName : fName,
		lastName : lName,
		age : age,
		toString:function (){return this.firstName  + ' ' + this.lastName + ', age: ' + this.age;}
	}
}