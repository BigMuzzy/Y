<Query Kind="Program" />

// https://leetcode.com/problems/letter-case-permutation/description/
void Main()
{
	LetterCasePermutation("a1b2c").Dump();
}

IList<string> LetterCasePermutation(string S)
{
	var result = new List<string>();
	
	result.Add(S);
	
	LetterCasePermutationHelper(S, result, 0);
	
	return result;	
}

void LetterCasePermutationHelper(string S, IList<string> list, int i)
{
	// base case
	if(i >= S.Length)
	{
		return;	
	}
	
	for (int j = i; j < S.Length; j++)
	{
		// choose
		if(char.IsDigit(S[j]))
		{
			continue;
		}
		
		S = FlipCharCase(S, j);
		list.Add(S);
		
		// explore
		LetterCasePermutationHelper(S, list, j+1);

		// unchoose
		S = FlipCharCase(S, j);
	}
}

string FlipCharCase(string S, int i)
{
	var tmp = S.ToArray();
	tmp[i] = char.IsLower(tmp[i]) ? char.ToUpper(tmp[i]) : char.ToLower(tmp[i]);
	return new string(tmp);
}