<Query Kind="Program" />

// coins generic case
void Main()
{
//	var list = new List<int> { 4016, 984, 2134, 5, 346, 10000, 567, 4016, 984, 2134, 5, 346, 10000, 567 };
	var list = new List<int> { 20, 3, 1, 8, 2, 20 };

	List<int> intList = new List<int>();
	Random r = new Random();

	for (int i = 0; i < 50000; i++)
	{
		intList.Add(r.Next(0, 10000)); // populate random values.
	}

	//F(10, list, 2).Dump();
	F(5000, intList, 2).Dump();
	Results.Dump(true);
}

int F(int sum, List<int> list, int k)
{
	var m = new int[list.Max() + 1];

	foreach (var i in list)
	{
		m[i]++;
	}

	return FHelper(sum, m, 2);
}

List<List<int>> Results = new List<List<int>>();
Stack<int> CurrentSolution = new Stack<int>();

int FHelper(int sum, int[] m, int k)
{
	if (sum == 0 && k == 0)
	{
		Results.Add(CurrentSolution.ToList());
		return 1;
	}
	else if (sum <= 0 || k <= 0)
	{
		return 0;
	}

	int result = 0;
	for (int i = 1; i < m.Length; i++)
	{
		if (m[i] > 0)
		{
			m[i]--;
			CurrentSolution.Push(i);
			result += FHelper(sum - i, m, k - 1);
			CurrentSolution.Pop();
			m[i]++;
		}
	}

	return result;
}