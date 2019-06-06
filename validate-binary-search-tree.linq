<Query Kind="Program" />

// https://leetcode.com/problems/validate-binary-search-tree/

void Main()
{
	
}

bool IsValidBST(TreeNode root)
{
	return IsValidBST(root, long.MinValue, long.MaxValue);
}

bool IsValidBST(TreeNode root, long lower, long upper)
{
	if(root == null)
	{
		return true;
	}
	
	bool result = true;
	
	if(root.val >= upper || root.val <= lower)
	{
		return false;
	}
	
	result &= IsValidBST(root.left, lower, root.val);
	result &= IsValidBST(root.right, root.val, upper);

	return result;
}


class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}