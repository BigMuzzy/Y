<Query Kind="Program" />

// https://leetcode.com/problems/trim-a-binary-search-tree/description/
void Main()
{
}

TreeNode TrimBST(TreeNode root, int L, int R)
{
	if (root == null)
	{
		return null;
	}

	TreeNode result = null;

	if (root.val < L)
	{
		result = TrimBST(root.right, L, R);
	}

	if (R < root.val)
	{
		result = TrimBST(root.left, L, R);
	}

	if (L <= root.val && root.val <= R)
	{
		result = root;
		result.left = TrimBST(root.left, L, R);
		result.right = TrimBST(root.right, L, R);
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