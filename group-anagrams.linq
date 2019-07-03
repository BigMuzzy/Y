<Query Kind="Program" />

// https://leetcode.com/problems/group-anagrams
void Main()
{
	string[] input = {"eat", "tea", "tan", "ate", "nat", "bat"};
	GroupAnagrams(input).Dump();
}

IList<IList<string>> GroupAnagrams(string[] strs)
{
	var result = new Dictionary<string, IList<string>>();
	
	foreach (var str in strs)
	{
		char[] arr = str.ToArray();
		Array.Sort(arr);
		var key = new string(arr);
		
		if(result.ContainsKey(key))
		{
			result[key].Add(str);
		}
		else
		{
			result.Add(key, new List<string> {str});
		}
	}
	
	return result.Select(x => x.Value).ToList();
}