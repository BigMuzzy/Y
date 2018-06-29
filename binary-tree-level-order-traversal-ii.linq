<Query Kind="Program" />

// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/
void Main()
{
	var root = new TreeNode(3);
	root.left = new TreeNode(9);

	root.right = new TreeNode(20);
	root.right.left = new TreeNode(15);
	root.right.right = new TreeNode(7);

	LevelOrderBottom(root).Dump();
}

IList<IList<int>> LevelOrderBottom(TreeNode root)
{
	var result = new List<IList<int>>();

	LevelOrderBottomHelper(root, result, 0);

	return result;
}

void LevelOrderBottomHelper(TreeNode root, List<IList<int>> result, int level)
{
	if (root == null)
	{
		return;
	}

	if (result.Count <= level)
	{
		result.Insert(result.Count - level, new List<int>() { root.val });
	}
	else
	{
		result[result.Count - level - 1].Add(root.val);
	}

	LevelOrderBottomHelper(root.left, result, level + 1);
	LevelOrderBottomHelper(root.right, result, level + 1);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}