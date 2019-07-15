<Query Kind="Program" />

// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/

void Main()
{
}

public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
{
	var parents = new Dictionary<TreeNode, TreeNode>();
	var visited = new HashSet<TreeNode>();

	FindParents(root, null, parents);

	var result = new List<int>();

	DistanceKHelper(target, K, parents, visited, result);

	return result;
}

void DistanceKHelper(TreeNode root, int k, Dictionary<TreeNode, TreeNode> parents, HashSet<TreeNode> visited, List<int> result)
{
	if (root == null || visited.Contains(root))
	{
		return;
	}
	
	visited.Add(root);
	
	if (k == 0)
	{
		result.Add(root.val);
	}

	DistanceKHelper(root.left, k - 1, parents, visited, result);
	DistanceKHelper(root.right, k - 1, parents, visited, result);
	DistanceKHelper(parents[root], k - 1, parents, visited, result);
}

void FindParents(TreeNode root, TreeNode parent, Dictionary<TreeNode, TreeNode> parents)
{
	if (root == null)
	{
		return;
	}

	parents[root] = parent;

	FindParents(root.left, root, parents);
	FindParents(root.right, root, parents);
}


public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}
