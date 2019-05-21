<Query Kind="Program" />

// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
void Main()
{
	var tree = new TreeNode(1)
	{
		right = new TreeNode(2)
	};
	
	KthSmallest(tree, 2).Dump();
}

public int KthSmallest(TreeNode root, int k)
{
	var queue = new Queue<int>();
	
	KthSmallestHelper(root, queue);
	
	int result = -1;
	for(; k > 0; k--)
	{
		result = queue.Dequeue();
	}
	
	return result;
} 


void KthSmallestHelper(TreeNode node, Queue<int> queue)
{
	if(node == null)
	{
		return;
	}

	KthSmallestHelper(node.left, queue);
	queue.Enqueue(node.val);
	KthSmallestHelper(node.right, queue);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}
