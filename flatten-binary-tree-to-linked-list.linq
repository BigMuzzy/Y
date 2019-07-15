<Query Kind="Program" />

//https://leetcode.com/problems/flatten-binary-tree-to-linked-list/description/

void Main()
{

}

void Flatten(TreeNode root)
{

}

(TreeNode head, TreeNode tail) FlattenHelper(TreeNode root)
{
	if (root == null)
	{
		return (null, null);
	}

	var leftList = FlattenHelper(root.left);
	var rightList = FlattenHelper(root.right);

	if (leftList.tail != null)
	{
		leftList.tail.right = rightList.head;
	} 
	
	root.right = leftList.head != null ? 
		leftList.head :
		rightList.head != null ? 
			rightList.head :
			root.right;
	
	var tail = rightList.tail != null ?
		rightList.tail :
		leftList.tail != null ?
			leftList.tail : root;
	return (root, tail);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}