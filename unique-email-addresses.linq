<Query Kind="Program" />

// https://leetcode.com/problems/unique-email-addresses/
void Main()
{
	NumUniqueEmails(new []{"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"}).Dump();
}

public int NumUniqueEmails(string[] emails)
{
	var result = new HashSet<string>();

	foreach (var email in emails)
	{
		var tmp = new StringBuilder();
		bool beforeAmp = true;
		bool beforePlus = true;
		foreach (var c in email)
		{
			switch (c)
			{
				case '@':
					beforeAmp = false;
					tmp.Append(c);
					break;
				case '.' when beforeAmp:
					break;
				case '.' when beforeAmp == false:
					tmp.Append(c);
					break;
				case '+':
					beforePlus = false;
					break;
				case var c1 when beforePlus || beforeAmp == false:
					tmp.Append(c1);
				break;
			}
		}
		result.Add(tmp.ToString());
	}
	
	return result.Count;
}

// Define other methods and classes here
