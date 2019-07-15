<Query Kind="Program" />

void Main()
{
	string[] user0 = { "a", "b", "c", "d", "e", "f", "g", "h" };
	string[] user1 = { "a", "x", "c", "d", "b", "c", "d", "e" };
	
	LCSuff("BANANA", "ANABANA", 6, 7, 0).Dump();

	LCSuff1(user0, user1, 8, 8, 0).Dump();

}


int LCSuff(string a, string b, int al, int bl, int count)
{
	if (al == 0 || bl == 0)
	{
		return 0;
	}

	if (a[al - 1] == b[bl - 1])
	{
		count = LCSuff(a, b, al - 1, bl - 1, count + 1);
	}

	count = Math.Max(
		count,
		Math.Max(
			LCSuff(a, b, al - 1, bl, 0),
			LCSuff(a, b, al, bl - 1, 0)
		));


	return count;
}

int LCSuff1(string[] a, string[] b, int al, int bl, int count)
{
	if (al == 0 || bl == 0)
	{
		return 0;
	}

	if (string.Equals(a[al - 1], b[bl - 1]))
	{
		count = LCSuff1(a, b, al - 1, bl - 1, count + 1);
	}

	count = Math.Max(
		count,
		Math.Max(
			LCSuff1(a, b, al - 1, bl, 0),
			LCSuff1(a, b, al, bl - 1, 0)
		));


	return count;
}
