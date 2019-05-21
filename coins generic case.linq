<Query Kind="Program" />

// coins generic case
void Main()
{
	List<int> intList = new List<int>();
	Random r = new Random();

	for (int i = 0; i < 500000; i++)
	{
		intList.Add(r.Next(0, 10000)); // populate random values.
	}

	var result = GetPossibleCombinations(intList, 5000);
	Console.WriteLine($"{result}");
}

int GetPossibleCombinations(List<int> intList, long totalValue)
{
	var Results = new Dictionary<string, List<int>>();
	var currentSolution = new List<int>();

	var maxElement = intList.Max();

	var m = new int[maxElement + 1];

	foreach (var i in intList)
	{
		m[i]++;
	}

	GetPossibleCombinationsHelper(totalValue, m, 2, currentSolution, Results);

	return Results.Count;
}

void GetPossibleCombinationsHelper(long sum, int[] m, int k, List<int> chosen, Dictionary<string, List<int>> results)
{
	if (sum == 0 && k == 0)
	{	
		var key = ArrayToString(chosen);
		if (results.Keys.Contains(key) == false)
		{
			//Console.WriteLine(key);
			results.Add(key, chosen);
		}
		return;
	}

	for (int i = 0; i < m.Length; i++)
	{
		if (sum - i < 0 || k <= 0)
		{
			return;
		}

		if (m[i] == 0)
		{
			continue;
		}

		m[i]--;
		chosen.Add(i);
		GetPossibleCombinationsHelper(sum - i, m, k - 1, chosen, results);
		chosen.RemoveAt(chosen.Count - 1);
		m[i]++;
	}
}

string ArrayToString(List<int> list)
{
	int[] a = list.ToArray();
	Array.Sort(a);
	return string.Join(";", a);
}