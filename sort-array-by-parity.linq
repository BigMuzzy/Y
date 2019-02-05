<Query Kind="Program" />

//https://leetcode.com/problems/sort-array-by-parity/

void Main()
{
	SortArrayByParity(new int[] {3,1,2,4}).Dump();
}

int[] SortArrayByParity(int[] A)
{
	FindFirstEven(A);
	
	int i = FindInitialBorder(A); // first odd elment index
	
	for(int j = i + 1; j < A.Length; j++)
	{
		if(A[j] % 2 == 0)
		{
			swap(A, i, j); 
			i++;
		}
	}
	
	return A;
}

void FindFirstEven(int[] A)
{
	int i = 0;
	while(i < A.Length && A[i] % 2 != 0)
	{
		i++;
	}
}

int FindInitialBorder(int[] A)
{
	int i = 0;
	while(i < A.Length && A[i] % 2 == 0) 
	{
		 i++;
	}
	
	return i;
}

void swap(int[] A, int i, int j)
{
	int tmp = A[i];
	A[i] = A[j];
	A[j] = tmp;
}