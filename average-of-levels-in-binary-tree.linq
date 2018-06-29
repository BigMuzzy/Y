<Query Kind="Program" />

// https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
void Main()
{
	var root = new TreeNode(5);
	root.left = new TreeNode(4);
	root.left.left = new TreeNode(2);
	root.left.left.left = new TreeNode(1);
	root.left.left.right = new TreeNode(3);
	root.right = new TreeNode(8);
	root.right.left = new TreeNode(6);
	root.right.right = new TreeNode(7);
	
	AverageOfLevels(root).Dump();
}

IList<double> AverageOfLevels(TreeNode root)
{
	if (root == null)
	{
		return new List<double>();
	}

	var values = new List<List<int>>();

	AverageOfLevelsHelper(root, values, 0);

	return values.Select(x => x.Average()).ToList();
}

void AverageOfLevelsHelper(TreeNode root, List<List<int>> values, int level)
{
	if (values == null)
	{
		throw new ArgumentNullException(nameof(values));
	}

	if (root == null)
	{
		return;
	}

	if (values.Count() > level)
	{
		values[level].Add(root.val);
	}
	else
	{
		values.Add(new List<int>() { root.val });
	}

	AverageOfLevelsHelper(root.left, values, level + 1);
	AverageOfLevelsHelper(root.right, values, level + 1);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}