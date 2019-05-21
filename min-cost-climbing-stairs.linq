<Query Kind="Program" />

//https://leetcode.com/problems/min-cost-climbing-stairs/description/
void Main()
{
	var cost = new []{10, 15, 20};
	MinCostClimbingStairs(cost).Dump();
}

int MinCostClimbingStairs(int[] cost)
{
	var cache = new int[cost.Length+1];
	for (int i = 0; i < cache.Length; i++)
	{
		cache[i] = -1;		
	}
	return MinCostClimbingStairsHelper(cost, cost.Length, cache);
}

int MinCostClimbingStairsHelper(int[] cost, int i, int[] cache)
{
	if(cache[i] > -1)
	{
		return cache[i];
	}
	if(i < 2)
	{
		return cost[i];
	}

	var f1 = MinCostClimbingStairsHelper(cost, i - 1, cache);
	var f2 = MinCostClimbingStairsHelper(cost, i - 2, cache);
	cache[i] = (i == cost.Length ? 0 : cost[i]) + Math.Min(f1, f2);

	return cache[i];
}