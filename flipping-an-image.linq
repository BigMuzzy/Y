<Query Kind="Program" />

// https://leetcode.com/problems/flipping-an-image/description/
void Main()
{
	FlipAndInvertImage(new int[][] { new int[] { 1, 1, 1, 0 }, new int[] { 1, 1, 0, 1 }, new int[] { 0, 0, 0, 0 } }).Dump();
}

int[][] FlipAndInvertImage(int[][] A)
{
	int temp;
	foreach (var row in A)
	{
		for (int i = 0; i < (row.Length / 2 + row.Length % 2); i++)
		{
			temp = row[i];
			row[i] = invert(row[row.Length - 1 - i]);
			row[row.Length - 1 - i] = invert(temp);
		}
	}

	return A;
}

int invert(int x)
{
	return x == 0 ? 1 : 0;
}