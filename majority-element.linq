<Query Kind="Program" />

// https://leetcode.com/problems/majority-element/description/
void Main()
{
	MajorityElement2(new[] {2,2,1,1,1,2,2}).Dump();
}

public int MajorityElement(int[] nums)
{
	var dic = new Dictionary<int, int>();
	
	foreach (var num in nums)
	{
		if(dic.ContainsKey(num))
		{
			dic[num] = dic[num] + 1;
		}
		else
		{
			dic[num] = 1;
		}
		
		if(dic[num] > (nums.Length / 2))
		{
			return num;
		}
	}
	
	return -1;
}


public int MajorityElement2(int[] nums)
{
	int result = 0;
	int count = 0;

	foreach (var num in nums)
	{
		if(count == 0)
		{
			result = num;
		}
		
		if(result != num)
		{
			count--;
		}
		else
		{
			count++;
		}
	}
	
	return result;
}

// Define other methods and classes here
