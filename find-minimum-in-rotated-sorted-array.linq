<Query Kind="Program" />

// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

void Main()
{
	FindMin(new int[]{3,1,2}).Dump();
}

int FindMin(int[] nums)
{
	if( nums.Length == 0)
	{
		return -1;
	}
	
	if(nums.Length == 1)
	{
		return nums[0];
	}
	
	if(nums[0] < nums[nums.Length - 1])
	{
		return nums[0];
	}
	
	return nums[FindPivot(nums, 0, nums.Length - 1) + 1];
}

int FindPivot(int[] m, int l, int r)
{
	if (l > r)
	{
		return -1;
	}

	if (l == r)
	{
		return l;
	}

	int mid = l + (r - l) / 2;

	if (m[mid] > m[mid + 1])
	{
		return mid;
	}

	if (m[mid] < m[l])
	{
		return FindPivot(m, l, mid - 1);
	}
	
	return FindPivot(m, mid + 1, r);
}