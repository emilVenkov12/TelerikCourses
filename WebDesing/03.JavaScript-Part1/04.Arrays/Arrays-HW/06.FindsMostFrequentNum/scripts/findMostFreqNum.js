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
function findMaxIncreasingSeq(arr) {
			var maxIndStart = 0;
			var maxLen = 1;
			var tempLen = 0;
			var tempIndStart = 0;
			for (var i = 0; i < arr.length - 1; i++) {
				if (arr[i] ==	 arr[i + 1]) {
					tempLen++;
				}
				else{
					if (tempLen > maxLen) {
						maxLen = tempLen;
						maxIndStart = tempIndStart;
					};
					tempLen = 0;
					tempIndStart = i + 1;
				}
			};
			if (tempLen > maxLen) {
				maxLen = tempLen;
				maxIndStart = tempIndStart;
			};

			return arr[maxIndStart] + " (" + (maxLen + 1) + " times).";
		}
function findMostFreqNum(arr) {
	var sortedArr = sort(arr);
	var output = findMaxIncreasingSeq(arr);
	jsConsole.writeLine("Most frequent number is " + output);
}