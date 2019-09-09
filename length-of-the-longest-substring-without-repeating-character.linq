<Query Kind="Program" />

// https://www.geeksforgeeks.org/length-of-the-longest-substring-without-repeating-characters/
void Main()
{
	Length("GEEKSFORGEEKS").Dump();
	Length("ABDEFGABEF").Dump();
}

int Length(string s)
{
	int l = 0;
	int r = 0;
	int ml = 0;
	int mr = 0;
	int maxLen = 0;
	
	var chars = new HashSet<char>();
	
	while(r < s.Length)
	{
		//advance r
		if (chars.Contains(s[r]))
		{
			l = r;
			chars.Clear();
		}
		
		chars.Add(s[r]);

		//check if new solution found
		if((r - l + 1) > maxLen)
		{
			ml = l;
			mr = r;
			maxLen = r - l + 1;
		}
		
		r++;
	}
	
	return maxLen;
}
