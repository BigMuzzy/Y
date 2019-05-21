<Query Kind="Program" />

// https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree/
void Main()
{

}

TreeNode BstToGst(TreeNode root)
{
	if (root == null)
	{
		return null;
	}

	BstToGstHelper(root, 0);

	return root;
}

int BstToGstHelper(TreeNode root, int greaterSum)
{
	if (root == null)
	{
		return greaterSum;
	}

	int rightSum = BstToGstHelper(root.right, greaterSum);
	root.val = rightSum + root.val;
	int totalSum = BstToGstHelper(root.left, root.val);

	return totalSum;
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}

