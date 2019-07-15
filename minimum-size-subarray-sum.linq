<Query Kind="Program" />

//https://leetcode.com/problems/minimum-size-subarray-sum/

void Main()
{
	int s = 7;
	int[] nums = {2, 3, 1, 2, 4, 3};

	int s1 = 2;
	int[] nums1 = { 2 };

	MinSubArrayLen(s1, nums1).Dump();
}


int MinSubArrayLen(int s, int[] nums)
{
	int l = 0;
	int r = 0;
	int len = int.MaxValue;
	int sum = 0;
	int result = 0;
	
	while(r < nums.Length)
	{
		// find enough solution
		sum += nums[r];

		r++;

		while (sum >= s)
		{
			// check if it is better
			if (r - l < len)
			{
				len = r - l;
				result = len;
			}

			// try to improve
			sum -= nums[l];
			
			l++;
		}
	}
	
	return result;
}