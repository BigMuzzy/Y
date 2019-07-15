<Query Kind="Program" />

// https://leetcode.com/problems/search-in-rotated-sorted-array/

void Main()
{
	int[] m1 = { 4, 5, 6, 7, 0, 1, 2 };
	int[] m2 = {  };

	Search(m2, 1).Dump();
}

int Search(int[] nums, int target)
{
	int pivot = FindPivot(nums, 0, nums.Length - 1).Dump();
	//search left
	int result = BinarySearch(nums, 0, pivot, target);
	//search right
	if (result < 0)
	{
		result = BinarySearch(nums, pivot + 1, nums.Length - 1, target);
	}

	return result;
}

int FindPivot(int[] nums, int l, int r)
{
	if (l > r)
	{
		return -1;
	}
	
	if(l == r)
	{
		return l;
	}

	int mid = l + (r - l) / 2;
	if (nums[mid] > nums[mid + 1])
	{
		return mid;
	}

	if (nums[mid] < nums[l])
	{
		return FindPivot(nums, l, mid - 1);
	}

	return FindPivot(nums, mid + 1, r);
}

int BinarySearch(int[] nums, int l, int r, int target)
{
	if (l > r)
	{
		return -1;
	}

	int mid = l + (r - l) / 2;

	if (nums[mid] == target)
	{
		return mid;
	}

	if (nums[mid] > target)
	{
		return BinarySearch(nums, l, mid - 1, target);
	}

	return BinarySearch(nums, mid + 1, r, target);
}