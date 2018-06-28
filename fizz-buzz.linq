<Query Kind="Program" />

// https://leetcode.com/problems/fizz-buzz/description/
void Main()
{
	FizzBuzz(15).Dump();
}

IList<string> FizzBuzz(int n)
{
	var result = new List<string>();

	for (int i = 1; i <= n; i++)
	{
		var temp = new StringBuilder();

		if ((i % 3) == 0)
		{
			temp.Append("Fizz");
		}

		if ((i % 5) == 0)
		{
			temp.Append("Buzz");
		}

		if (temp.Length == 0)
		{
			temp.Append(i);
		}

		result.Add(temp.ToString());
	}

	return result;
}