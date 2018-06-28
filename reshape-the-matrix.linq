<Query Kind="Program" />

// https://leetcode.com/problems/reshape-the-matrix/description/
void Main()
{
	MatrixReshape(new int[,] { { 1 }, { 2 }, { 3 }, { 4 } }, 2, 2).Dump();
}

int[,] MatrixReshape(int[,] nums, int r, int c)
{
	if(nums == null)
	{
		return null;
	}
	
	if (nums.Length != r * c)
	{
		return nums;
	}

	int[,] result = new int[r, c];

	int k = 0;
	int l = 0;

	for (int i = 0; i < nums.GetLength(0); i++)
	{
		for (int j = 0; j < nums.GetLength(1); j++, l++)
		{
			if (l >= c)
			{
				l = 0;
				k++;
			}

			result[k, l] = nums[i, j];
		}
	}

	return result;
}