function onGetWordOccBtnClick(){

	var text = document.getElementById("tb-text").value;
	var word = document.getElementById("tb-word").value;
	var isCaseSensitive = document.getElementById("tb-isCaseSens").checked;
	var output = document.getElementById("tb-output");
	var wordCount = getWordOcc(text, word, isCaseSensitive);
	output.innerHTML += "The count of given word is the text is: " 
		+ wordCount + "\n";
}
function getWordOcc(text,word, isCaseSensitive) {
		function getWordOccurrences(word, matchCase) {
			var regex = new RegExp('\\b' + word + '\\b', matchCase);

			var occurencesFound = text.match(regex);
			if (occurencesFound != null) {
				return occurencesFound.length;
			}
			else{
				return 0;
			};
		}
		switch (arguments.length) {
			case 2:
				return getWordOccurrences(word, "gi");
			case 3:
				return isCaseSensitive ? 
					getWordOccurrences(word, "g") :
					 getWordOccurrences(word, "gi");
		}
	}