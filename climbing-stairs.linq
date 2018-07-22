<Query Kind="Program" />

// https://leetcode.com/problems/climbing-stairs/description/

void Main()
{
	ClimbStairs2(38).Dump();
}

int ClimbStairs(int n)
{
	int result = 0;
	var table = new int[n + 1];
	ClimbStairsHelper(n, ref result, table);
	return result;
}

void ClimbStairsHelper(int n, ref int result, int[] table)
{
	if (n < 0)
	{
		return;
	}

	if (n == 0)
	{
		result++;
		return;
	}

	if (table[n] != 0)
	{
		result += table[n];
		return;
	}

	for (int i = 1; i <= 2; i++)
	{
		ClimbStairsHelper(n - i, ref result, table);
	}

	table[n] = result;
}


int ClimbStairs2(int n)
{
	var result = new int[n + 1];

	result[1] = 1;
	result[2] = 2;

	for (int i = 3; i <= n; i++)
	{
		result[i] = result[i - 1] + result[i - 2];
	}

	return result[n];
}