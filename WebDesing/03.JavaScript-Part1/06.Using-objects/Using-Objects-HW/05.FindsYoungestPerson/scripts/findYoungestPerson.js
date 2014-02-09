function onUseTestFuncBtnClick() {
	var people = [buildPerson("Gosho", "Petrov", 31),
		buildPerson("Bay", "Ivam", 81),
		buildPerson("Grany", "Yaga", 150),];
	jsConsole.writeLine("People for test: </br>" + people.join("; ") + "</br>");
	jsConsole.writeLine("Youngest person is : " + getYoungestPerson(people));

}
function getYoungestPerson (people) {
	var minAgeInd = 0;
	for (var i = 0; i < people.length; i++) {
		if (people[i].age < people[minAgeInd].age) {
			minAgeInd = i;
		};
	};
	return people[minAgeInd];
}
function buildPerson (fName, lName, age) {
	return {
		firstName : fName,
		lastName : lName,
		age : age,
		toString:function (){return this.firstName  + ' ' + this.lastName + ', age: ' + this.age;}
	}
}