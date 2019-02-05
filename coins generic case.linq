<Query Kind="Program" />

// coins generic case
void Main()
{
	var list = new List<int>{ 2, 3, 3, 2};
	F(5, list, 2).Dump();
}

int F(int sum, List<int> list, int k)
{
	var X = new int[list.Max() + 1];
	
	foreach (var i in list)
	{
		X[i]++;
	}
	
	return FHelper(sum, X, 2);
}

 Dictionary<int,int> Results = new Dictionary<int, int>();

int FHelper(int sum, int[] X, int k)
{
	if(sum == 0 && k == 0)
	{
		return 1;
	}
	else if((sum==0 && k!=0) || (sum!=0 && k==0))
	{
		return 0;
	}
	
	int result = 0;
	
	for(int i = 1; i < X.Length; i++)
	{
		if (X[i] > 0)
		{
			X[i]--;
			result += FHelper(sum - i, X, k - 1);
			X[i]++;
		}
	}
		
	return result;
}