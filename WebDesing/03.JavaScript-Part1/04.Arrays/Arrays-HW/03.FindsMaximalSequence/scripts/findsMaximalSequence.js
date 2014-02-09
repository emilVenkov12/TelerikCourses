function findMaxSequence(arr) {
			var maxIndStart = 0;
			var maxLen = 1;
			var tempLen = 0;
			var tempIndStart = 0;
			for (var i = 0; i < arr.length - 1; i++) {
				if (arr[i] == arr[i + 1]) {
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

			var output = "";
			for (var i = maxIndStart; i <= maxIndStart + maxLen; i++	) {
				output += arr[i] + ", ";
			};
			jsConsole.writeLine(output);
		}