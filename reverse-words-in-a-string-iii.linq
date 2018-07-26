<Query Kind="Program" />

// https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
void Main()
{
	ReverseWords("Let's take LeetCode contest").Dump();
}

string ReverseWords(string s) 
{
	var result = new StringBuilder();
	var stack = new Stack<char>();

	foreach(var c in s)
	{
		if(c != ' ')
		{
			stack.Push(c);
		}
		else
		{
			while (stack.Count != 0)
			{
				result.Append(stack.Pop());
			}
			result.Append(' ');
		}
	}
	while (stack.Count != 0)
	{
		result.Append(stack.Pop());
	}

	return result.ToString();
}