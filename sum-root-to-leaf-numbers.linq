<Query Kind="Program" />

// https://leetcode.com/problems/sum-root-to-leaf-numbers/

void Main()
{

}

int SumNumbers(TreeNode root)
{
	if (root == null)
	{
		return 0;
	}

	var stack = new Stack<int>();
	var subResults = new List<int>();

	Sum(root, stack, subResults);

	return (int)subResults.Sum();
}

void Sum(TreeNode root, Stack<int> stack, List<int> subResults)
{
	stack.Push(root.val);

	if (root.left == null && root.right == null)
	{
		subResults.Add(Count(stack));
		stack.Pop();
		return;
	}

	if (root.left != null)
	{
		Sum(root.left, stack, subResults);
	}
	if (root.right != null)
	{
		Sum(root.right, stack, subResults);
	}
	stack.Pop();
}

int Count(Stack<int> stack)
{
	int result = 0;
	int mult = 1;
	var stack1 = new Stack<int>();
	while (stack.Count > 0)
	{
		stack1.Push(stack.Peek());
		result += stack.Pop() * mult;
		mult *= 10;
	}

	while (stack1.Count > 0)
	{
		stack.Push(stack1.Pop());
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