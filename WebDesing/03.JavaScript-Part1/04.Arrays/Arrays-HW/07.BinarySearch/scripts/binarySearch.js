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

function searchBinary (arr, number) {
		var first = 0, last = arr.length - 1;
        var index = -1;
        while (first <= last)
        {
            var mid = Math.floor((first + last) / 2);
            if (arr[mid] == number)
            {
                index = mid;
                break;
            }
            else if (arr[mid] > number)
            {
                last = mid - 1;
            }
            else if (arr[mid] < number)
            {
                first = mid + 1;
            }
        }
       return index;
}
function binarySearch(arr, number) {
	var sortedArr = sort(arr);
	var index = searchBinary(sortedArr, number);

	if (index != -1) {
		jsConsole.writeLine("Element is found on index " + index);
	}
	else{
		jsConsole.writeLine("The element is not in the given array!");
	};
}