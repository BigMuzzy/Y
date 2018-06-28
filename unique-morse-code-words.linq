<Query Kind="Program" />

// https://leetcode.com/problems/unique-morse-code-words/description/
void Main()
{
	UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" }).Dump();
}

int UniqueMorseRepresentations(string[] words)
{
	if (words == null)
	{
		return 0;
	}

	string[] alphabet = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
	var hashSet = new HashSet<string>();

	foreach (var word in words)
	{
		var temp = new StringBuilder();
		foreach (var c in word)
		{
			temp.Append(alphabet[c - 'a']);
		}

		hashSet.Add(temp.ToString());
	}

	return hashSet.Count();
}