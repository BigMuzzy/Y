<Query Kind="Program" />

// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/

void Main()
{
	BuildTree(new int[] { 9, 3, 15, 20, 7 }, new int[] { 9, 15, 7, 20, 3 }).Dump();
}

int pos;

TreeNode BuildTree(int[] inorder, int[] postorder)
{
	var map = new Dictionary<int, int>();
	for(int i = 0; i < inorder.Length; i++)
	{
		map.Add(inorder[i], i);
	}
	
	pos =  inorder.Length - 1;
	return BuildTree(map, postorder, 0, inorder.Length - 1);
}

TreeNode BuildTree(Dictionary<int, int> map, int[] postorder, int l, int r)
{
	if(l > r)
	{
		return null;
	}
	
	var node = new TreeNode(postorder[pos--]);
	int inPos = map[node.val];
	node.right = BuildTree(map, postorder, inPos + 1, r);
	node.left = BuildTree(map, postorder, l, inPos - 1);
	
	return node;
}

class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}