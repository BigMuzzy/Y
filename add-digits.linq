<Query Kind="Program" />

//https://leetcode.com/problems/add-digits/description/

void Main()
{
	AddDigits(149).Dump();
}

int AddDigits(int num) {
	
	if(num < 10)
	{
		return num;
	}
	
	int result;
	
	do
	{
		result = 0;
		result += (num % 10) + AddDigits(num / 10);
		num = result;
		
	} while(result > 9);
	
	return result;
}