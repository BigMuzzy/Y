<Query Kind="Program" />

// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/

void Main()
{
	
}

IList<IList<int>> ZigzagLevelOrder(TreeNode root)
{
	var result = new List<IList<int>>();
	ZigzagLevelOrderHelper(root, result, 0);
	return result;
}

void ZigzagLevelOrderHelper(TreeNode node, IList<IList<int>> result, int level)
{
	if(node == null)
	{
		return;
	}
	
	if(result.Count == level)
	{
		result.Add(new List<int>());
	}
	
	if(level % 2 == 0)
	{
		result[level].Add(node.val);
	}
	else
	{
		result[level].Insert(0, node.val);
	}

	ZigzagLevelOrderHelper(node.left, result, level + 1);
	ZigzagLevelOrderHelper(node.right, result, level + 1);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}