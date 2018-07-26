<Query Kind="Program" />

// https://leetcode.com/problems/happy-number/description/
void Main()
{
	IsHappy(9).Dump();
}

bool IsHappy(int n) {

	if(n == 0)
	{
		return false; 
	}

	if(n == 1)
	{
		return true;
	}
	
	int result = 0;
	int prev;
	
	do
	{
		prev = result;
		result = IsHappyHelper(n);
		n = result;
		if(prev == result)
		{
			return false;
		}
	} while (result != 1);
	
	return true;
}

int IsHappyHelper(int n)
{
	if(n == 0)
	{
		return 0;
	}
	
	if(n == 1)
	{
		return 1;
	}
	
	int i = n % 10;
	
	return i*i + IsHappyHelper(n / 10);
}