<Query Kind="Program" />

// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
void Main()
{
	
}

void Flatten(TreeNode root)
{
	FlattenHelper(root);
}

(TreeNode head, TreeNode tail) FlattenHelper(TreeNode root)
{
	if (root == null)
	{
		return (null, null);
	}
	
	var leftList = FlattenHelper(root.left);
	var rightList = FlattenHelper(root.right);
	
	var leftAndRight = Concatinate(leftList, rightList);
	
	root.right = leftAndRight.head;
	root.left = null;
	
	return (root, leftAndRight.tail??root);
}

(TreeNode head, TreeNode tail) Concatinate(
	(TreeNode head, TreeNode tail) left,
	(TreeNode head, TreeNode tail) right)
{
	if(left.head == null)
	{
		return right;
	}
	
	if(right.head == null)
	{
		return left;
	}
	
	left.tail.right = right.head;
	
	return (left.head, right.tail);
}

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
