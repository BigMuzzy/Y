<Query Kind="Program" />

// https://leetcode.com/problems/distribute-coins-in-binary-tree/
void Main()
{

}

int moves = 0;

int DistributeCoins(TreeNode root)
{
	DistributeCoinsHelper(root);
	return moves;
}

/* {#_fo_elements, #_of_coins} */

int[] DistributeCoinsHelper(TreeNode root)
{
	if (root == null)
	{
		return new int[] { 0, 0 };
	}

	int[] left = DistributeCoinsHelper(root.left);
	int[] right = DistributeCoinsHelper(root.right);
	moves += Math.Abs(left[0] - left[1]) + Math.Abs(right[0] - right[1]);
	return new int[] { left[0] + right[0] + 1, left[1] + right[1] + root.val };
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}