<Query Kind="Program" />

//https://leetcode.com/problems/distribute-candies/description/

void Main()
{
	DistributeCandies(new int[]{1,1,1,1,2,2,2,3,3,3}).Dump();
}

int DistributeCandies(int[] candies)
{
	var hashTable = new HashSet<int>();
	int cnt = candies.Length / 2;

	foreach (var candy in candies)
	{
		hashTable.Add(candy);
		if(hashTable.Count == cnt)
		{
			break;
		}
	}

	return hashTable.Count;
}