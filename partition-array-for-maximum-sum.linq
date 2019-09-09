<Query Kind="Program" />

//https://leetcode.com/problems/partition-array-for-maximum-sum/

void Main()
{
	int[] A = { 1, 15, 7, 9, 2, 5, 10 };
	int K = 3;

	MaxSumAfterPartitioning(A, K).Dump();
}

int MaxSumAfterPartitioning(int[] A, int K)
{
}

int MaxSumAfterPartitioningHelper(int[] A, int K, int l, int r)
{
	if (l > r)
	{
		return 0;
	}

	for (int i = l + 1; i < r && i < l + K; i++)
	{
		if (A[i] > maxVal)
		{
			maxInd = i;
			maxVal = A[i];
		}
	}
	int subLen = maxInd - l + 1;

	int[] nextResults = new int[K - subLen + 1];
	for (int i = 1; i < nextResults.Length + 1; i++)
	{
		nextResults[i - 1] = MaxSumAfterPartitioningHelper(A, K, l + subLen + i - 1, r);
	}
	int nextMax = nextResults.Max(x => x);
	subLen += Array.FindIndex(nextResults, x=> x == nextMax);
	return subLen * maxVal + nextMax;
}