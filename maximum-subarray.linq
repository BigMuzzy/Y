<Query Kind="Program" />

// https://leetcode.com/problems/maximum-subarray/

void Main()
{
	int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
	int[] nums1 = { -2, -1 };
	MaxSubArray(nums1).Dump();	
}

int MaxSubArray(int[] nums) {

	int sp = nums[0];
	int sm = nums[0];
	
	for(int i = 1; i < nums.Length; i++)
	{
		sm = Math.Max(sp, sm);
		sp = Math.Max(nums[i], sp+nums[i]);
	}
	
	return Math.Max(sp, sm);
}