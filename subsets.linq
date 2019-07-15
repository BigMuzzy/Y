<Query Kind="Program" />

// https://leetcode.com/problems/subsets/description/
void Main()
{
	Subsets(new int[] { 1, 2, 3 }).Dump();
}

IList<IList<int>> Subsets(int[] nums)
{
	var result = new List<IList<int>>();
	var chosen = new List<int>();

	SubsetsHelper(nums.ToList(), result, chosen);

	return result;
}

void SubsetsHelper(IList<int> nums, IList<IList<int>> result, IList<int> chosen)
{
	//base case
	if (nums.Count <= 0)
	{
		result.Add(chosen.ToList());
	}
	else
	{
		int first = nums[0];
		nums.RemoveAt(0);

		//choos first in
		chosen.Add(first);
		SubsetsHelper(nums, result, chosen);

		//choos first out
		chosen.RemoveAt(chosen.Count - 1);
		SubsetsHelper(nums, result, chosen);

		//unchoose
		nums.Insert(0, first);
	}
}