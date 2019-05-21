<Query Kind="Program" />

<<<<<<< HEAD
void Main()
{
	SortArrayByParity(new int[]{0,2,1,3,5,4,7,6,8}).Dump();
=======
//https://leetcode.com/problems/sort-array-by-parity/

void Main()
{
	SortArrayByParity(new int[] {3,1,2,4}).Dump();
>>>>>>> 8708d84032afdf50e094320033ce00beb4709318
}

int[] SortArrayByParity(int[] A)
{
<<<<<<< HEAD
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
=======
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
>>>>>>> 8708d84032afdf50e094320033ce00beb4709318
}

void swap(int[] A, int i, int j)
{
	int tmp = A[i];
	A[i] = A[j];
	A[j] = tmp;
}