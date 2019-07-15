<Query Kind="Program" />

//https://leetcode.com/problems/minimum-window-substring/

void Main()
{
	string S = "ADOBECODEBANC", T = "ABC";
	string S1 = "A", T1 = "A";

	MinWindow(S, T).Dump();
}

string MinWindow(string s, string t)
{
	var table = new Dictionary<char, int>();
	
	foreach (char c1 in t)
	{
		if(table.ContainsKey(c1))
		{
			table[c1]++;
		}
		else
		{
			table[c1] = 1;	
		}
	}
	
	char c;
	int l = 0;
	int r = 0;
	int len = int.MaxValue;
	int need2FindCharsCnt = table.Count;
	string result = string.Empty;

	while(r < s.Length)
	{
		//find all required chars
		c = s[r];
		if (table.ContainsKey(c))
		{
			table[c]--;
			if(table[c] == 0)
			{
				need2FindCharsCnt--;
			}
		}
		
		r++;

		while (need2FindCharsCnt == 0)
		{
			//check if better solution found
			if(r - l < len)
			{
				len = r - l;
				result = s.Substring(l, len);
			}

			//try to improve
			c = s[l];
			if(table.ContainsKey(c))
			{
				table[c]++;
				if(table[c] > 0)
				{
					need2FindCharsCnt++;
				}
			}
			
			l++;
		}
	}
	
	return result;
}