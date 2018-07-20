<Query Kind="Program" />

// https://leetcode.com/problems/coin-change/description/
void Main()
{
	var coins = new int[]{474,83,404,3};
//	Array.Sort(coins);
	coinChange1(coins, 264, new int[264]).Dump();
	CoinChange(coins, 264).Dump();
	//{474,83,404,3}, 264
	//{ 1, 2, 5 }, 11
	//{470,35,120,81,121}, 9825
	//{ 270, 373, 487, 5, 62 }, 8121
}

int CoinChange(int[] coins, int amount)
{
	var table = new int[amount];
	return CoinChangeHelper(coins, amount, table);
}

int CoinChangeHelper(int[] coins, int amount, int[] table)
{
	if (amount == 0)
	{
		return 0;
	}

	if (amount < 0)
	{
		return -1;
	}

	if ( table[amount-1] != 0)
	{
		return table[amount-1];
	}

	int min = int.MaxValue;

	for (int i = 0; i < coins.Length ; i++)
	{
		int tmp = CoinChangeHelper(coins, amount - coins[i], table);
		
		if(tmp >= 0 && (tmp + 1) < min)
		{
			min = (int)(tmp + 1);
		}
	}
	
	table[amount-1] = (min == int.MaxValue) ? -1 : min;

	return table[amount-1];
}

int coinChange1(int[] coins, int amount, int[] count)
{
	if (amount < 0) return -1;
	if (amount == 0) return 0;
	if (count[amount - 1] != 0) return count[amount - 1];
	int min = int.MaxValue;
	foreach (int coin in coins)
	{
		int res = coinChange1(coins, amount - coin, count);
		if (res >= 0 && (res+1) < min)
			min = 1 + res;
	}
	count[amount - 1] = (min == int.MaxValue) ? -1 : min;
	return count[amount - 1];
}


