<Query Kind="Program" />

// https://leetcode.com/problems/number-of-lines-to-write-string/description/
void Main()
{
	int[] widths = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
	string S = "abcdefghijklmnopqrstuvwxyz";

	NumberOfLines(widths, S).Dump();
}

int[] NumberOfLines(int[] widths, string S)
{
	var result = new int[2];
	int line = 1;
	int width = 0;
	int tmp;

	foreach (var c in S)
	{
		tmp = widths[c - 'a'];
		if ((width + tmp) > 100)
		{
			line++;
			width = 0;
		}
		width += tmp;
	}

	result[0] = line;
	result[1] = width;
	return result.ToArray();
}