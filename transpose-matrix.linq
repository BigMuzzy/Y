<Query Kind="Program" />

// https://leetcode.com/problems/transpose-matrix/description/
void Main()
{
	var A = new int[][] { new int[]{ 1, 2, 3 }, new int[]{ 4, 5, 6 }, new int[]{ 7, 8, 9 }};
	Transpose(A).Dump();
}

int[][] Transpose(int[][] A) {

	if(A == null)
	{
		return null;	
	}

	int cols = A[0].Length;
	int rows = A.Length;
	
	var result = new int[cols][];
	
	for (int i = 0; i < rows; i++)
	{
		for(int j = 0; j < cols; j++)
		{
			if (i == 0)
			{
				result[j] = new int[rows];
			}
			result[j][i] = A[i][j];
		}
	}
	
	return result;
}