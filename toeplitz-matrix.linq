<Query Kind="Program" />

// https://leetcode.com/problems/toeplitz-matrix/description/
void Main()
{
	IsToeplitzMatrix(new int[,]
	{
	{1,2}
//	{1,2,3,4},
//	{5,1,2,3},
//	{9,5,1,2}
	})
	.Dump();
}

bool IsToeplitzMatrix(int[,] matrix)
{
	if(matrix == null)
	{
		return false;	
	}
	
	bool result = true;
	for (int i = matrix.GetLength(0) - 2; i >= 0; i--)
	{
		for (int j = 0; j < matrix.GetLength(1) - 1; j++)
		{
			result &= (matrix[i, j] == matrix[i + 1, j + 1]);
		}
	}
	return result;
}