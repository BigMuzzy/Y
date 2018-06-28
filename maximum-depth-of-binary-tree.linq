<Query Kind="Program" />

// https://leetcode.com/problems/trim-a-binary-search-tree/description/
void Main()
{
}

int MaxDepth(TreeNode root)
{
	if (root == null)
	{
		return 0;
	}

	var left = MaxDepth(root.left);
	var right = MaxDepth(root.right);

	return (left > right ? left : right) + 1;
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}