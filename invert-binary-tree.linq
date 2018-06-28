<Query Kind="Program" />

// https://leetcode.com/problems/invert-binary-tree/description/
void Main()
{
}

TreeNode InvertTree(TreeNode root)
{
	if (root == null)
	{
		return null;
	}

	var nodes = new Queue<TreeNode>();

	InvertTreeHelper(root, nodes);

	return root;
}

void InvertTreeHelper(TreeNode root, Queue<TreeNode> queue)
{
	if (root == null)
	{
		return;
	}

	TreeNode temp = root.left;
	root.left = root.right;
	root.right = temp;

	queue.Enqueue(root.left);
	queue.Enqueue(root.right);

	while (queue.Count > 0)
	{
		InvertTreeHelper(queue.Dequeue(), queue);
	}
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}
