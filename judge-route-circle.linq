<Query Kind="Program" />

// https://leetcode.com/problems/judge-route-circle/description/
void Main()
{
	JudgeCircle("DDUDLRRRRLLL").Dump();
}

bool JudgeCircle(string moves)
{
	if (string.IsNullOrWhiteSpace(moves))
	{
		return true;
	}

	if ((moves.Length % 2) > 0)
		return false;

	int vertical = 0;
	int horizontal = 0;

	foreach (var move in moves)
	{
		switch (move)
		{
			case 'U':
				vertical++;
				break;
			case 'D':
				vertical--;
				break;
			case 'R':
				horizontal++;
				break;
			case 'L':
				horizontal--;
				break;
		}
	}

	return vertical == 0 && horizontal == 0;
}