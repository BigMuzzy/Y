<Query Kind="Program" />

// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/

void Main()
{

}

Node Connect(Node root)
{
	if(root == null)
	{
		return null;	
	}
	
	var queue = new Queue<Node>();
	queue.Enqueue(root);
	Node right = null;
	while (queue.Count > 0)
	{
		int levelSize = queue.Count;
		for (int i = 0; i < levelSize - 1; i++)
		{
			var node = queue.Dequeue();
			node.next = right;
			if (node.right != null)
			{
				queue.Enqueue(node.right);
			}
			if (node.left != null)
			{
				queue.Enqueue(node.left);
			}
			if(i == 0)
			{
				right = null;
			}
			else
			{
				right = node;	
			}
		}
	}
	
	return root;
}

public class Node
{
	public int val;
	public Node left;
	public Node right;
	public Node next;

	public Node() { }
	public Node(int _val, Node _left, Node _right, Node _next)
	{
		val = _val;
		left = _left;
		right = _right;
		next = _next;
	}
}