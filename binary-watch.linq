<Query Kind="Program" />

// https://leetcode.com/problems/binary-watch/description/

void Main()
{
	ReadBinaryWatch(1);
	
}

IList<string> ReadBinaryWatch(int num)
{
	List<string> result = new List<string>();
	ReadBinaryWatch(num, result);
	return result;
	
}

void ReadBinaryWatch(int num, IList<string> result)
{
	int a = 1;
	if(num == 0)
	{
	}
	
	for (int i = 1; i <= num; i++)
	{
		for (int j = 1; j < 10; j++)
		{
			a <<= 1;
			a.Dump();
		}
	}
}