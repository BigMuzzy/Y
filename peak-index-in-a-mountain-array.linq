<Query Kind="Program" />

// https://leetcode.com/problems/peak-index-in-a-mountain-array/description/
void Main()
{
	PeakIndexInMountainArray(new int[] {12,13,19,41,55,69,70,71,96,72}).Dump();
}

int PeakIndexInMountainArray(int[] A)
{
	return PeakIndexInMountainArrayHelper(A, 0, A.Length-1);
}

int PeakIndexInMountainArrayHelper(int[] A, int start, int end)
{
	int peak = (end - start) / 2 + start;

	if (A[peak - 1] < A[peak] && A[peak] > A[peak + 1])
		return peak;

	if (A[peak - 1] < A[peak])
		return PeakIndexInMountainArrayHelper(A, peak, end);


	return PeakIndexInMountainArrayHelper(A, start, peak + 1);
}
