<Query Kind="Program" />

//https://leetcode.com/problems/add-two-numbers/

void Main()
{
	
}

public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
	ListNode result = null;
	ListNode cur = null;
	int c = 0;
	
	while(l1 != null && l2 != null)
	{
		if(result == null)
		{
			cur = result = new ListNode(0);
		}
		else
		{
			cur.next = new ListNode(0);
			cur = cur.next;
		}
		cur.val = (l1.val + l2.val + c) % 10;
		c = (l1.val + l2.val + c) / 10
		l1 = l1.next;
		l2 = l2.next;
	}
	if (cur != null)
	{
		cur.next = l1 != null ? l1 : l2;
	}
	return result;
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}
