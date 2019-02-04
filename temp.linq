<Query Kind="Program" />

List<int> compareList = new List<int>();
// GetPossibleCombination method.
// This method finds out the unique number of possible combinations where 
// addition of any 2 values from the list is exactly equal to 'totalValue'
int GetPossibleCombinations(List<int> intList, long totalValue)
{
	var dictionary = new int[intList.Max() + 1];

	foreach (var i in intList)
	{
		dictionary[i]++;
	}

	return CombinationsHelper(totalValue, dictionary, 2);
}

int CombinationsHelper(long sum, int[] dictionary, int k)
{
	if (sum == 0 && k == 0)
	{
		return 1;
	}
	else if ((sum == 0 && k != 0) || (sum != 0 && k == 0))
	{
		return 0;
	}

	int result = 0;

	for (int i = 1; i < dictionary.Length; i++)
	{
		if (dictionary[i] > 0)
		{
			dictionary[i]--;
			result += CombinationsHelper(sum - i, dictionary, k - 1);
			dictionary[i]++;
		}
	}

	return result;
}

// This method creates a list of possible values we have 
bool IsPairUnique(int v1, int v2)
{
	if (compareList.Contains(v1 * 10 + v2) == true || compareList.Contains(v2 * 10 + v1) == true)
		return false;
	else
	{
		// else add a new one
		compareList.Add(v1 * 10 + v2);
		compareList.Add(v2 * 10 + v1);
	}

	return true;
}

void Main(string[] args)
{
	int intListSize = 500000; // Optimize it for numbers upto 500,000
	long totalValue = 5000;

	List<int> intList = new List<int>();
	Random r = new Random();
	
	for (int i = 0; i < intListSize; i++)
	{
		intList.Add(r.Next(0, 10000)); // populate random values.
	}

	Stopwatch sw = new Stopwatch();
	sw.Start();

	// Find the number of unique pairs in 'intList' such that 
	// their addition is exactly equal to 'totalValue'
	int res = GetPossibleCombinations(intList, totalValue).Dump();

	sw.Stop();
	Console.WriteLine(sw.Elapsed.ToString());
}