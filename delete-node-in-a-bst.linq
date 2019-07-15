<Query Kind="Program" />

// https://leetcode.com/problems/delete-node-in-a-bst/

void Main()
{

}

TreeNode DeleteNode(TreeNode root, int key)
{
	if (root == null)
	{
		return null;
	}

	if (root.val == key)
	{
		return Delete(root);
	}
	else if (key < root.val)
	{
		root.left = DeleteNode(root.left, key);
	}
	else if (key > root.val)
	{
		root.right = DeleteNode(root.right, key);
	}

	return root;
}

TreeNode Delete(TreeNode root)
{
	if (root.left == null && root.right == null)
	{
		return null;
	}

	if (root.left == null)
	{
		return root.right;
	}

	if (root.right == null)
	{
		return root.left;
	}
	
	TreeNode node = root.left;
	while (node.right != null)
	{
		node = node.right;
	}

	node.right = root.right;
	return root.left;
}

class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}