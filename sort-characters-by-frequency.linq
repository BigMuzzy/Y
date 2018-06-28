<Query Kind="Program" />

// https://leetcode.com/problems/sort-characters-by-frequency/description/
void Main()
{
	FrequencySort("tree").Dump();
}

string FrequencySort(string s)
{
	if (string.IsNullOrEmpty(s))
	{
		return s;
	}

	var dictionary = new Dictionary<char, int>();

	foreach (char c in s)
	{
		if (dictionary.ContainsKey(c))
		{
			dictionary[c]++;
		}
		else
		{
			dictionary[c] = 1;
		}
	}

	var result = new StringBuilder();

	foreach (var item in dictionary.OrderByDescending(x => x.Value))
	{
		for (int i = 0; i < item.Value; i++)
		{
			result.Append(item.Key);
		}
	}

	return result.ToString();
}