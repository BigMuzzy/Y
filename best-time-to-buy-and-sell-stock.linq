<Query Kind="Program" />

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
void Main()
{
	MaxProfit(new int[] { }).Dump();
}

int MaxProfit(int[] prices)
{
	int min = int.MaxValue, result = 0;

	if(prices == null)
	{
		return result;
	}
	
	for (int i = 0; i < prices.Length; i++)
	{
		if(prices[i] > min)
		{
			if (result < (prices[i] - min))
			{
				result = prices[i] - min;
			}
		}
		else
		{
			if(prices[i] < min)
			{
				min = prices[i];
			}
		}
	}

	return result;
}