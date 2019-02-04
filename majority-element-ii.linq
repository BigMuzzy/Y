<Query Kind="Program" />

// https://leetcode.com/problems/majority-element-ii/description/
void Main()
{
	MajorityElement2(new[] {1,2}).Dump();
}

public IList<int> MajorityElement2(int[] nums)
{
	var result = new List<int>();
	int m = 0;
	int count = 0;
	int num;
	for (int i = 0; i < nums.Length; i++)
	{
		num = nums[i];
		
		if(count == 0)
		{
			m = num;
		}
		
		if(m != num)
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
