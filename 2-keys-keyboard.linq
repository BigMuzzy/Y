<Query Kind="Program" />

// https://leetcode.com/problems/2-keys-keyboard/

void Main()
{
	MinSteps(3).Dump();
}

int MinSteps(int n)
{
	return (int)F(n, 0, 1);
}

long F(int target, int memory, int notepad)
{
	if (target == 1)
	{
		return 0;
	}
	if (target == notepad)
	{
		return 0;
	}

	if (target < notepad)
	{
		return int.MaxValue;
	}
	
	var newMemory = notepad;
	long fcp = (long)2 + F(target, newMemory, notepad + newMemory);
	long fp = (long)1 + (memory == 0 ? int.MaxValue : F(target, memory, notepad + memory));
	return Math.Min(fcp, fp);
}

