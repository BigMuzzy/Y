<Query Kind="Program" />

// https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
void Main()
{
	
	
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

IList<double> AverageOfLevels(TreeNode root) {
	var values = new List<List<int>>();
	
	AverageOfLevelsHelper(root, values, 0);
	
	return values.Select(x => x.Average()).ToList();
}

void AverageOfLevelsHelper(TreeNode node, List<List<int>> values, int level) {
	if(values == null) {
		throw new ArgumentNullException(nameof(values));
	}

	if (node == null)
	{
		return;
	}

	if(values.Count() > level) {
		values[level].Add(node.val);
	}
	else
	{
		values.Add(new List<int>() { node.val });
	}

	AverageOfLevelsHelper(node.left, values, level + 1);
	AverageOfLevelsHelper(node.right, values, level + 1);
}