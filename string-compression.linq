<Query Kind="Program" />

// https://leetcode.com/problems/string-compression/description/
void Main()
{
	var m = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
	var m2 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c'};
	Compress(m2).Dump();
	m2.Dump();
}

int Compress(char[] chars) {
	char c = chars[0];
	int cnt = 1;
	int j = 1;
	
	for (int i = 1; i <= chars.Length; i++)
	{
		if((i == chars.Length) || (chars[i] != c))
		{
			//record result
			chars[j-1] = c;
			if (cnt > 1)
			{
				j += SpellNumber(chars, cnt, j) + 1;
			}
			else
			{
				//reset
				j++;
				cnt = 1;
				if (i < chars.Length)
				{
					c = chars[i];
				}
			}
		}
		else
		{
			cnt++;
		}
	}
	
	return j-1;
}

int SpellNumber(char[] chars, int number, int start)
{
	int d = 1000;
	bool started = false;
	int result = 0;
	
	while(number != 0)
	{
		if ((number / d) > 0)
		{
			started = true;
		}

		if (started)
		{
			chars[start++] = (char)((number / d) + '0');
			result++;
			number = number - d * (number / d);
		}		
		
		d /= 10;
	}
	
	return result;
}