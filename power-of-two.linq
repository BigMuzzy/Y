<Query Kind="Program" />

// https://leetcode.com/problems/power-of-two/description/
void Main()
{
	IsPowerOfTwo(8).Dump();
}

bool IsPowerOfTwo(int n) {	
	while(n > 0 && ((n & 1) == 0))
	{
		n >>= 1;
	}
	
	if(n == 1)
	{
		return true;
	}
	
	return false;

}