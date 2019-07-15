<Query Kind="Program" />

//https://leetcode.com/problems/minimum-window-substring/

void Main()
{
	string S = "ADOBECODEBANC", T = "q";

	string S1 = "AAABCD", T1 = "ABC";

	MinWindow(S, T).Dump();
}

string MinWindow(string s, string t)
{
	Dictionary<char, int> table = FillTable(t);

	int l = -1;
	int r = 0;
	int len = int.MaxValue;
	int numberOfChars2Find = table.Count;
	char c;

	int i = -1;
	int j = -1;
	while (i < s.Length)
	{
		while (numberOfChars2Find > 0 && ++i < s.Length)
		{
			c = s[i];
			if (table.ContainsKey(c))
			{
				table[c]--;
				if (table[c] == 0)
				{
					numberOfChars2Find--;
				}
			}
		}

		while (numberOfChars2Find == 0 && ++j < i)
		{
			c = s[j];
			if (table.ContainsKey(c))
			{
				table[c]++;
				if (table[c] > 0)
				{
					numberOfChars2Find++;
				}
			}
		}

		if (i - j + 1 < len)
		{
			l = j;
			r = i;
			len = r - l + 1;
		}
	}
	return l >= 0 ? s.Substring(l, len) : string.Empty;
}

Dictionary<char, int> FillTable(string t)
{
	var result = new Dictionary<char, int>();

	foreach (var c in t)
	{
		if (result.ContainsKey(c))
		{
			result[c]++;
		}
		else
		{
			result[c] = 1;
		}
	}

	return result;
}
