<Query Kind="Program" />

// https://leetcode.com/problems/two-sum/

void Main()
{
	TwoSum(new []{2, 7, 11, 15}, 9).Dump();
}

public int[] TwoSum(int[] nums, int target)
{
	var hash = new Dictionary<int, int>();
	for (int i = 0; i < nums.Length; i++)
	{
		int compliment = target - nums[i];
		if(hash.ContainsKey(compliment))
		{
			return new int[]{(int)hash[compliment], i};
		}
		hash[nums[i]] = i;
	}

	return default(int[]);
}

// Define other methods and classes here
