<Query Kind="Program" />

// https://leetcode.com/problems/binary-tree-level-order-traversal/description/ (medium)
void Main()
{

}

IList<IList<int>> LevelOrder(TreeNode node)
{
	var result = new List<IList<int>>();
	LevelOrderHelper(node, result, 0);
	
	return result;
}

void LevelOrderHelper(TreeNode node, IList<IList<int>> result, int level)
{
	if(node == null)
	{
		return;
	}
	
	if(result.Count == level)
	{
		result.Add(new List<int>());
	}

	result[level].Add(node.val);

	LevelOrderHelper(node.left, result, level + 1);
	LevelOrderHelper(node.right, result, level + 1);
}


public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}