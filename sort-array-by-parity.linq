<Query Kind="Program" />

void Main()
{
	SortArrayByParity(new int[]{0,2,1,3,5,4,7,6,8}).Dump();
}

int[] SortArrayByParity(int[] A)
{
	int i = 0;

	while (i < A.Length && A[i] % 2 != 0)
	{
		i++;
	}
	
	swap(A, i, 0);
	
	i = 1;

	while (i < A.Length && A[i] % 2 == 0)
	{
		i++;
	}

	for (int j = i j < A.Length; j++)
	{
		if (A[j] % 2 != 0)
		{
			swap(A, i, j);
			i++;
		}
	}
	
	int[] R = new int[i];
	Array.Copy(A, R, i);
	return R;
}

void swap(int[] A, int i, int j)
{
	int tmp = A[i];
	A[i] = A[j];
	A[j] = tmp;
}