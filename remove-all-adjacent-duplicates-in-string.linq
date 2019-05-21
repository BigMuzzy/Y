<Query Kind="Program" />

// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string
void Main()
{
	RemoveOuterParentheses("abbaca").Dump();
}

string RemoveOuterParentheses(string S)
{
	Stack<char> stack = new Stack<char>();
	
	char top;
	for (int i = 0; i < S.Length; i++)
	{
		if (stack.Count > 0)
		{
			top = stack.Peek();
		}
		else
		{
			top = '#';	
		}
		if(top != S[i])
		{
			stack.Push(S[i]);
		}
		else
		{
			stack.Pop();	
		}
	}
	
	char[] result = new char[stack.Count];
	int size = stack.Count;
	for (int i = 1; i <= size; i++)
	{
		result[size - i] = stack.Pop();
	}
	
	return new string(result);
}