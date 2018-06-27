<Query Kind="Program" />

// https://leetcode.com/problems/invert-binary-tree/description/
void Main()
{
	
}

public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
}

TreeNode InvertTree(TreeNode root)
{
	var nodes = new Queue<TreeNode>();
	
	InvertTreeHelper(root, nodes);
	
	return root;
}

void InvertTreeHelper(TreeNode node, Queue<TreeNode> nodes)
{
	if (nodes == null)
	{
		throw new ArgumentNullException(nameof(nodes));
	}

	if(node == null) {
		return;
	}
	
	TreeNode buf;
	
	buf = node.left;
	node.left = node.right;
	node.right = buf;
	
	nodes.Enqueue(node.left);
	nodes.Enqueue(node.right);
	
	while (nodes.Count > 0)
	{
		InvertTreeHelper(nodes.Dequeue(), nodes);
	}
}
