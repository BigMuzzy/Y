<Query Kind="Program" />

void Main()
{
	Solution("><").Dump();
	Solution("><>><<").Dump();
}

string Solution(string angles)
{
	int cnt = 0;
	int missingOpenCnt = 0;
	
	foreach (var c in angles)
	{
		if(c == '<')
		{
			cnt++;
		} 
		else if(c == '>')
		{
			if(cnt == 0)
			{
				missingOpenCnt++;
			}
			else
			{
				cnt--;
			}
		}
	}
	
	var sb = new StringBuilder();
	sb.Append('<', missingOpenCnt);
	sb.Append(angles);
	sb.Append('>', cnt);
	
	return sb.ToString();
}