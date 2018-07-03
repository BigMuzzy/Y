<Query Kind="Program" />

//https://leetcode.com/problems/self-dividing-numbers/description/

void Main()
{
	SelfDividingNumbers(1, 22).Dump();
}

IList<int> SelfDividingNumbers(int left, int right)
{
	var result = new List<int>();
	int d;
	int r;
	bool isResult;
	for (int i = left; i <= right; i++)
	{
		r = i;
		isResult = true;
		do
		{
			d = r % 10;
			if (d == 0)
			{
				isResult = false;
				break;
			}
			
			if (i % d == 0)
			{
				r /= 10;
			}
			else
			{
				isResult = false;
				break;
			}

		} while(r > 0);
		
		if(isResult) 
		{
			result.Add(i);
		}
	}
	
	return result;
}