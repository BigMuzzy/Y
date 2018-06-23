<Query Kind="Program" />

// https://leetcode.com/problems/unique-morse-code-words/description/
void Main()
{
	UniqueMorseRepresentations(new string[]{"gin", "zen", "gig", "msg"}).Dump();
}

int UniqueMorseRepresentations(string[] words)
{
	string [] alphabet = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
	var vacabulary = new HashSet<string>();
	
	foreach (var word in words)
	{
		var newWord = new StringBuilder();
		foreach (char letter in word)
		{
			newWord.Append(alphabet[letter - 'a']);
		}
		
		vacabulary.Add(newWord.ToString());
	}
	
	return vacabulary.Count();
}

