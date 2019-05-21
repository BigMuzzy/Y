<Query Kind="Program" />

//https://leetcode.com/problems/find-common-characters/
void Main()
{
	var input = new[]{"bella","label","roller"};
	
	CommonChars(input).Dump();
}

IList<string> CommonChars(string[] A)
{
	var dic = new Dictionary<char, int>();
	
	for(int i = 0; i < A.Length; i++)
	{
		for(int j = 0; j < A[i].Length; j++)
		{
			if (dic.Keys.Contains(A[i][j]))
			{
				if (dic[A[i][j]] == 0)
				{
					dic[A[i][j]]++;
				}
				else
				{
					dic[A[i][j]]--;
				}
			}
			else
			{
				dic[A[i][j]] = 1;
			}
		}
	}
	
	var result = new List<string>();
	foreach (var item in dic)
	{
		if(item.Value > 1)
		{
			for (int i = 0; i < item.Value/A.Length; i++)
			{
				result.Add(item.Key.ToString());
			}
		}
	}
	
	return result;
}