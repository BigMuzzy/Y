<Query Kind="Program" />

// https://leetcode.com/problems/peak-index-in-a-mountain-array/description/
void Main()
{
	PeakIndexInMountainArray(new int[] { 12, 13, 19, 41, 55, 69, 70, 71, 96, 72 }).Dump();
}

int PeakIndexInMountainArray(int[] A)
{
	if(A == null)
	{
		return 0;	
	}
	
	return PeakIndexInMountainArrayHelper(A, 0, A.Length - 1);
}

int PeakIndexInMountainArrayHelper(int[] A, int lo, int hi)
{
	int mid = (hi - lo) / 2 + lo;

	if (A[mid - 1] < A[mid] && A[mid] > A[mid + 1])
		return mid;

	if (A[mid - 1] < A[mid])
		return PeakIndexInMountainArrayHelper(A, mid, hi);

	return PeakIndexInMountainArrayHelper(A, lo, mid + 1);
}