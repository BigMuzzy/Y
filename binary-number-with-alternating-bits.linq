<Query Kind="Program" />

//https://leetcode.com/problems/binary-number-with-alternating-bits/description/
void Main()
{
	HasAlternatingBits(7).Dump();
}

bool HasAlternatingBits(int n)
{	
	int pre = 1 & n;
	int cur;
	do {
		n = n >> 1;
		cur = (n & 1);
		if ((pre ^ cur) != 1)
		{
			return false;
		}
		pre = cur;
		
	} while(n > 0);
	
	return true;
}