<Query Kind="Program" />

// https://leetcode.com/problems/permutations/
void Main()
{
	int[] A = {1,2,3};
	Permute(A).Dump();
}

IList<IList<int>> Permute(int[] nums)
{
	var result = new List<IList<int>>();
	var numList = nums.ToList();
	var choosen = new List<int>();
	
	PermuteHelper(numList, choosen, result);
	
	return result;
}

void PermuteHelper(List<int> nums, List<int> choosen, List<IList<int>> result)
{
	if(nums.Count == 0)
	{
		result.Add(choosen.ToList());
		
		return;
	}

	for (int i = 0; i < nums.Count; i++)
	{
		int k = nums[i];
		nums.RemoveAt(i);
		choosen.Add(k);

		PermuteHelper(nums, choosen, result);
		
		choosen.RemoveAt(choosen.Count - 1);
		nums.Insert(i, k);
	}
}