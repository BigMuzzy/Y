<Query Kind="Program" />

//https://leetcode.com/problems/insert-into-a-binary-search-tree/description/

void Main()
{
	
}

TreeNode InsertIntoBST(TreeNode root, int val)
{
	if(root == null)
	{
		return new TreeNode(val);
	}
	
	if(val < root.val)
	{
		root.left = InsertIntoBST(root.left, val);	
	}
	else
	{
		root.right = InsertIntoBST(root.right, val);
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
