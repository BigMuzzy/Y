<Query Kind="Program" />

//https://leetcode.com/problems/power-of-four/description/
void Main()
{
	IsPowerOfFour(6).Dump();
}

bool IsPowerOfFour(int num)
{	
	while((num > 0) && ((num & 1) == 0) && ((num & 2) == 0))
	{
		num >>= 2;
	}
	
	if(num == 1)
	{
		return true;
	}
	
	return false;
}