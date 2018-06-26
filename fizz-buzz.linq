<Query Kind="Program" />

// https://leetcode.com/problems/fizz-buzz/description/
void Main()
{
	FizzBuzz(15).Dump();
}

IList<string> FizzBuzz(int n)
{
	var result = new List<string>();
	
	for(int i = 1; i <= n; i++) {
		var sb = new StringBuilder();

		if((i % 3) == 0) {
			sb.Append("Fizz");
		}

		if((i % 5) == 0) {
			sb.Append("Buzz");
		}
		
		if(sb.Length == 0) {
			sb.Append(i);
		}
	
		result.Add(sb.ToString());
	} 
	
	return result;
}