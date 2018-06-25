<Query Kind="Program" />

// https://leetcode.com/problems/judge-route-circle/description/
void Main()
{
	JudgeCircle("DDUDLRRRRLLL").Dump();
}

bool JudgeCircle(string moves)
{
	if((moves.Length % 2) > 0)
		return false;

	int vTravel = 0;
	int hTravel = 0;

	foreach (var move in moves)
	{
		switch (move)
		{
			case 'U':
				vTravel++;
				break;
			case 'D':
				vTravel--;
				break;
			case 'R':
				hTravel++;
				break;
			case 'L':
				hTravel--;
				break;
		}
	}

	return vTravel == 0 && hTravel == 0;
}
