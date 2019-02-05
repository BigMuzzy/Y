<Query Kind="Program" />

// https://leetcode.com/problems/middle-of-the-linked-list/description/
void Main()
{
	
}

public class Solution
{
	public ListNode MiddleNode(ListNode head)
	{
		ListNode result = head;
		ListNode current = head;
		
		while(current != null && current.next != null) {
			result = result.next;
			current = current.next.next;
		}
		
		return result;
	}
}
// Define other methods and classes here

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
