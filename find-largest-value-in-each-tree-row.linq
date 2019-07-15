<Query Kind="Program" />

// https://leetcode.com/problems/find-largest-value-in-each-tree-row/

void Main()
{
	
}

IList<int> LargestValues(TreeNode root)
{
	var result = new List<int>();
	LargestValues(root, 0, result);
	
	return result;
}

void LargestValues(TreeNode root, int level, List<int> result)
{
	if(root == null)
	{
		return;
	}
	
	if(result.Count == level)
	{
		result.Add(root.val);
	}
	else
	{
		result[level] = Math.Max(result[level], root.val);
	}

	LargestValues(root.left, level + 1, result);
	LargestValues(root.right, level + 1, result);
}

class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}