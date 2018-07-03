<Query Kind="Program" />

// https://leetcode.com/problems/sum-of-two-integers/description/
void Main()
{
	GetSum(123, 23).Dump();
}

int GetSum(int a, int b)
{
	int mask = 1;
	int c = 0;
	int result = 0;
	
	for (int i = 0; i < 32; i++)
	{
		result |= TwoBitSum(a & mask, b & mask, ref c) << i;
		a >>= 1;
		b >>= 1;
	}
	return result;
}

int TwoBitSum(int a, int b, ref int c)
{
	int temp1 = a ^ b;
	int temp2 = a & b;
	int temp3 = c & temp1;
	int result = temp1 ^ c;
	c = temp2 | temp3;
	
	return result;
}