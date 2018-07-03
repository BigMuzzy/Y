<Query Kind="Program" />

// https://leetcode.com/problems/subsets/description/
void Main()
{
}

IList<IList<int>> Subsets(int[] nums)
{
	var result = new List<IList<int>>();
	
	SubsetsHelper(nums, result, 0);
	
	return result;
}

void SubsetsHelper(int[] nums, IList<IList<int>> list, int i)
{
	//base case
	if(nums.Length <= 0)
	{
		return;
	}
	
	//choos
	
	
	//explore
	
	//unchoose
}
