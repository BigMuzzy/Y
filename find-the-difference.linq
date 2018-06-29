<Query Kind="Program" />

// https://leetcode.com/problems/find-the-difference/description/

void Main()
{
	FindTheDifference2("qtwyeru", "qwzertyu").Dump();
}

char FindTheDifference(string s, string t) 
{
	var s1 = s.OrderBy(x => x).ToArray();
	var t1 = t.OrderBy(x => x).ToArray();

	for (int i = 0; i < s.Length; i++)
	{
		if(s1[i] != t1[i])
		{
			return t1[i];
		}
	}
	
	return t1.Last();
}

char FindTheDifference2(string s, string t)
{
	var hashSet = s.ToHashSet();
	
	foreach (var c in t)
	{
		if(hashSet.Any(x => x == c) == false)
		{
			return c;
		}
	}
	
	return '-';
}
