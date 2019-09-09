<Query Kind="Program" />

void Main()
{
	var a = new int[] {1,3,5,2,4,6};
	CountIntversions(a).Dump();
	a.Dump();
}

int CountIntversions(int[] a)
{
	return CountIntversionsSplit(a, 0, a.Length-1);
}

int CountIntversionsSplit(int[] a, int l, int r)
{
}