<Query Kind="Program" />

void Main()
{
	SpiralOrder(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
	SpiralOrder(new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }).Dump();
	SpiralOrder(new int[1, 3] { { 6, 9, 7 } }).Dump();

}


List<int> SpiralOrder(int[,] matrix)
{
	var result = new List<int>();
	int n = matrix.GetLength(0);
	int m = matrix.GetLength(1);

	int[] rd = new int[] { 0, 1, 0, -1 };
	int[] cd = new int[] { 1, 0, -1, 0 };
	var dim = new List<int>();
	int di = 0;

	int r = 0;
	int c = -1;
	int cnt = n + m - 1;
	for (int i = 0; i < cnt; i++)
	{
		if (i % 2 == 0)
		{
			dim.Add(m--);
		}
		else
		{
			dim.Add(--n);
		}
	}

	for (int i = 0; i < cnt; i++)
	{
		for (int j = 0; j < dim[i]; j++)
		{
			r += rd[di];
			c += cd[di];
			result.Add(matrix[r, c]);
		}
		di = ++di % 4;
	}

	return result;
}