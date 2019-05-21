<Query Kind="Program" />

// https://leetcode.com/problems/longest-valid-parentheses/

void Main()
{
	LongestValidParentheses("()(()").Dump();
}

int LongestValidParentheses(string s)
{
	int curLength = 0;
	int maxLength = 0;
	int prevLength = 0;
	int count = 0;
	
	foreach (char c in s)
	{
		if(c == '(')
		{
			count++;
			curLength++;
		}
		else
		{
			count--;	
		}
				
		if(count < 0)
		{
			maxLength = Math.Max(curLength * 2, maxLength);
			curLength = 0;
			prevLength = 0;
			count = 0;
		}
		else if(count == 0)
		{
			maxLength = Math.Max(prevLength + curLength * 2, maxLength);
			prevLength = curLength * 2;
			curLength = 0;
		}
	}

	maxLength = Math.Max((curLength - count) * 2, maxLength);

	return maxLength;
}
