<Query Kind="Program" />

// https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
void Main()
{
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