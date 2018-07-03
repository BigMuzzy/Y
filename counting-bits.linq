<Query Kind="Program" />

// https://leetcode.com/problems/counting-bits/description/
void Main()
{
	CountBits(16).Dump();
}

int[] CountBits(int num) {
	var result = new int[num+1];
	
	result[0] = 0;
	
	for (int i = 1, n = 0, j = 0; i <= num; i++)
	{
		if(i == (1 << n)) 
		{
			n++;
			j = 0;
			result[i] = 1;
		}
		else
		{
			result[i] = result[(1 << (n - 2))+j];
			j++;
		}
	}
	
	return result;
}

/*
			r i  n
1,0,0,0,0	1 1  0

0,1,0,0,0	1 2  1
1,1,0,0,0	2 3  1

0,0,1,0,0	1 4  2
1,0,1,0,0	2 5  2
0,1,1,0,0	2 6  2
1,1,1,0,0	3 7  2

0,0,0,1,0	1 8  3
1,0,0,1,0	2 9  3
0,1,0,1,0	2 10 3
1,1,0,1,0	3 11 3
0,0,1,1,0	2 12 3
1,0,1,1,0	3 13 3
0,1,1,1,0	3 14 3
1,1,1,1,0	4 15 3

0,0,0,0,1	1 16 4
*/