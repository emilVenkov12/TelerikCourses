function onExtractBtnClick(){
	var text = document.getElementById('input-text').value;

	var allEmails = extractPalindromes(text);
	for (var i = 0; i < allEmails.length; i++) {
		document.getElementById('output').innerHTML += 
			allEmails[i] + "</br>";
	};
	
}
function extractPalindromes(text) {
	var regex = /,|\s|\.|\?|!/gi;

	var words = text.split(regex);
	var palindromes = [];
	for (var i = 0; i < words.length; i++) {
		if(words[i].trim() != ""){
			if (isPalindrome(words[i])) {
				palindromes.push(words[i]);
			};
		}
	};
	return palindromes;
}
function isPalindrome (word) {
	for (var i = 0; i < word.length / 2; i++) {
		if (word.charAt(i) != word.charAt(word.length - i - 1)) {
			return false;
		};
	};
	return true;
}
function onGenerateDemoBtnClick() {
	document.getElementById('input-text').value = "ABBA , .lamal. exe, ls ono t";
}