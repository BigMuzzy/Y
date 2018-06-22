<Query Kind="Program" />

// https://leetcode.com/problems/jewels-and-stones/description/
void Main()
{
	NumJewelsInStones("z", "ZZ").Dump();
}

int NumJewelsInStones(string J, string S)
{
	var jewels = new HashSet<char>();

	foreach (var jem in J)
	{
		jewels.Add(jem);
	}

	int jewelsCount = 0;

	foreach (var s in S)
	{
		if (jewels.Any(x => x == s))
		{
			jewelsCount++;
		}
	}

	return jewelsCount;
}
