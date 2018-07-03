<Query Kind="Program" />

// https://leetcode.com/problems/array-partition-i/description/

void Main()
{
	ArrayPairSum(new int[] {1,2,3,4}).Dump();
}

int ArrayPairSum(int[] nums) 
{
	int result = 0;
	
	Array.Sort(nums);
	
	for (int i = 0; i < nums.Length; i+=2)
	{
		result += nums[i];
	}
	
	return result;
}
