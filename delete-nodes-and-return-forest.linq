<Query Kind="Program" />

//https://leetcode.com/problems/delete-nodes-and-return-forest/
void Main()
{
	// https://leetcode.com/problems/delete-nodes-and-return-forest/submissions/
}

IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
{
	var result = new List<TreeNode>();
	root = DelNodes(root, to_delete, result);
	if(root != null)
	{
		result.Add(root);
	}
	
	return result;
}

TreeNode DelNodes(TreeNode root, int[] to_delete, IList<TreeNode> result)
{
	if(root == null)
	{
		return null;
	}

	root.left = DelNodes(root.left, to_delete, result);
	root.right = DelNodes(root.right, to_delete, result);
	
	if(Array.Find(to_delete, x => x == root.val) != 0)
	{
		if(root.left != null) result.Add(root.left);
		if(root.right != null) result.Add(root.right);
		
		return null;
	}
	
	return root;
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}