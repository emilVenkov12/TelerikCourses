function sort(arr) {

		for (var i = 0; i < arr.length; i++)
		{
			var min = arr[i], index = i;
			for (var j = i + 1; j < arr.length; j++)
			{
				if (min > arr[j])
				{
					min = arr[j];
					index = j;
				}
			}
			var temp = arr[index];
			arr[index] = arr[i];
			arr[i] = temp;
		}
		return arr;
	}
function selectionSort (arr) {
	var sortedArr = sort(arr);
	var output = "";
	for (var i = 0; i < sortedArr.length; i++) {
		output += (sortedArr[i] + ' ');
	};

	jsConsole.writeLine(output);
}