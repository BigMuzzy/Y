<Query Kind="Program" />

// https://leetcode.com/problems/hamming-distance/description/
void Main()
{
	HammingDistance(1, 4).Dump();
}

int HammingDistance(int x, int y)
{
	int diff = x ^ y;
	int mask = 1;
	int distance = 0;
	
	for(int i = 0; i < 32; i++)
	{
		if((diff & mask) > 0)
			distance++;
		mask  = mask << 1;
	}
	
	return distance;
}