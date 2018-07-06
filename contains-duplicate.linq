<Query Kind="Program" />

// https://leetcode.com/problems/contains-duplicate/description/
void Main()
{
	ContainsDuplicate(new int[] { 1, 2, 3, 1 }).Dump();
}

bool ContainsDuplicate(int[] nums)
{
	var hashSet = new HashSet<int>();

	for (int i = 0; i < nums.Length; i++)
	{
		hashSet.Add(nums[i]);
		if (hashSet.Count < (i + 1))
		{
			return true;
		}
	}
	return false;
}
