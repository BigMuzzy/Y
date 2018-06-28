<Query Kind="Program" />

// https://leetcode.com/problems/jewels-and-stones/description/
void Main()
{
	NumJewelsInStones("z", "ZZ").Dump();
}

int NumJewelsInStones(string J, string S)
{
	if (string.IsNullOrWhiteSpace(J) || string.IsNullOrWhiteSpace(S))
	{
		return 0;
	}

	var hashSet = new HashSet<char>();

	foreach (var c in J)
	{
		hashSet.Add(c);
	}

	int result = 0;

	foreach (var c in S)
	{
		if (hashSet.Any(x => x == c))
		{
			result++;
		}
	}

	return result;
}