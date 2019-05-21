<Query Kind="Program" />

//https://leetcode.com/problems/range-sum-of-bst/

void Main()
{
	
}

int RangeSumBST(TreeNode root, int L, int R)
{
	if(root == null)
	{
		return 0;
	}
	
	int result = root.val >= L && root.val <=R ? root.val : 0;
	
	return result + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}