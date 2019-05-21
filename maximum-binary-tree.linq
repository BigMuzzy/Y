<Query Kind="Program" />

// https://leetcode.com/problems/maximum-binary-tree/

void Main()
{
	var arr = new []{3,2,1,6,0,5};
	ConstructMaximumBinaryTree(arr).Dump();
}

TreeNode ConstructMaximumBinaryTree(int[] nums)
{
	return ConstructHelper(0, nums.Length-1, nums);
}

TreeNode ConstructHelper(int l, int r, int[] nums)
{
	if(l > r)
	{
		return null;
	}
	
	int m = argMax(l, r, nums);
	return new TreeNode(nums[m])
	{
		left = ConstructHelper(l, m-1, nums),
		right = ConstructHelper(m+1, r, nums)
	};
}

int argMax(int l, int r, int[] a)
{
	if(l == r)
	{
		return l;
	}
	
	int max = 0;
	int result = l;
	
	for(int i = l; i <= r; i++)
	{
		if(a[i] > max)
		{
			max = a[i];
			result = i;
		}
	}
	return result;
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}