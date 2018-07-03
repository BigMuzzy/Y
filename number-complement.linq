<Query Kind="Program" />

// https://leetcode.com/problems/number-complement/description/
void Main()
{
	FindComplement(1).Dump();
}

int FindComplement(int num) {

	int result = ~num;
	int c = 0;
	
	while(result < 0) {
		result <<= 1;
		c++;
	}
	
	result >>= c;
	
	return result;

}