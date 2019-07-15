<Query Kind="Program" />

// https://leetcode.com/problems/count-complete-tree-nodes/

void Main()
{
	
}

int CountNodes(TreeNode root)
{
	int treeHeight = MaxDepth(root);
	
	return (1 << treeHeight)  - CountShortBranches(root, treeHeight, 0) - 1;
}

int MaxDepth(TreeNode root)
{
	if(root == null)
	{
		return 0;
	}
	
	return MaxDepth(root.left) + 1;
}

int CountShortBranches(TreeNode root, int th, int bh)
{
	if(root == null)
	{
		if(th == bh)
		{
			return 0;
		}
		
		return 1;
	}
	
	int rightShortBranchesCount = CountShortBranches(root.right, th, bh + 1);
	if(rightShortBranchesCount == 0)
	{
		return 0;
	}
	
	int leftShortBranchesCount = CountShortBranches(root.left, th, bh + 1);
	
	return rightShortBranchesCount + leftShortBranchesCount;
}


public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}