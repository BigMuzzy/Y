<Query Kind="Program" />

// https://leetcode.com/problems/coin-change/description/
void Main()
{
	CoinChange(new int[] { 470, 35, 120, 81, 121 }, 9825).Dump();
	//{470,35,120,81,121}, 9825
	//{ 270, 373, 487, 5, 62 }, 8121
}

int CoinChange(int[] coins, int amount)
{
	Array.Sort(coins);
	uint result = CoinChangeHelper(coins, coins.Length - 1, amount, 0);
	return result == int.MaxValue ? -1 : (int)result;
}

uint CoinChangeHelper(int[] soretedCoins, int maxIndex, int amount, uint sum)
{
	if (amount == 0)
	{
		return sum;
	}

	if (amount < 0)
	{
		return int.MaxValue;
	}

	if (maxIndex < 0)
	{
		return int.MaxValue;
	}

	if (amount < soretedCoins[0])
	{
		return int.MaxValue;
	}

	uint tmp1 = CoinChangeHelper(soretedCoins, maxIndex, amount - soretedCoins[maxIndex], sum + 1);

	uint tmp2 = CoinChangeHelper(soretedCoins, maxIndex - 1, amount, sum);

	return Math.Min(tmp1, tmp2);
}