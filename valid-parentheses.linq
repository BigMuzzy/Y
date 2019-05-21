<Query Kind="Program" />

// https://leetcode.com/problems/valid-parentheses/

void Main()
{
	IsValid("]").Dump();
}

bool IsValid(string s)
{
	Stack<char> stack = new Stack<char>();
	
	foreach (char c in s)
	{
		if(c == '(' || c == '[' || c == '{')
		{
			stack.Push(c);
		}
		else if(stack.Count > 0)
		{
			var open = stack.Pop();
			
			if(open == '(' && c != ')')
			{
				return false;
			}
			if (open == '[' && c != ']')
			{
				return false;
			}
			if (open == '{' && c != '}')
			{
				return false;
			}
		} else
		{
			return false;
		}
	}
	if (stack.Count != 0)
	{
		return false;
	}
	
	return true;
}
