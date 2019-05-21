<Query Kind="Program" />

//https://leetcode.com/problems/binary-tree-inorder-traversal/
void Main()
{
	
}

IList<int> InorderTraversal(TreeNode root)
{
	var result = new List<int>();
	
	InorderTraverseHelper(root, result);
	
	return result;
}

void InorderTraverseHelper(TreeNode node, IList<int> result)
{
	if (node == null)
	{
		return;
	}
	
	InorderTraverseHelper(node.left, result);
	result.Add(node.val);
	InorderTraverseHelper(node.right, result);
}

IList<int> InorderTraversal2(TreeNode node)
{
	var result = new List<int>();

	var s = new Stack<TreeNode>();
	
	while(s.Count > 0 || node != null)
	{
		if(node != null)
		{
			s.Push(node);
			node = node.left;
		}
		else
		{
			node = s.Pop();
			result.Add(node.val);
			node = node.right;
		}
	}

	return result;
}


public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}