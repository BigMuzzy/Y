<Query Kind="Program" />

// https://leetcode.com/problems/first-missing-positive/

void Main()
{
	int[] A = {1, 3, 6, 4, 1, 2};
	int[] A1 = { 1 };
	int[] A2 = { 1, 2, 3 };
	int[] A3 = { 0 };
	int[] A4 = { -1, -2, -3 };
	int[] A5 = { 1, -2, 3 };
	FirstMissingPositive(A2).Dump();
}

int FirstMissingPositive(int[] A) {
	Array.Sort(A);
	
	int result = 1;
	
	for (int i = 0; i < A.Length; i++)
	{
		
	}
}