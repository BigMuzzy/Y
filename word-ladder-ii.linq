<Query Kind="Program" />

//https://leetcode.com/problems/word-ladder-ii/
void Main()
{
	FindLadders("hit", "cog", new List<string>{"hot","dot","dog","lot","log","cog"}).Dump();
}

Dictionary<string, List<string>> g = new Dictionary<string, System.Collections.Generic.List<string>>();
IList<IList<string>> ladders = new List<IList<string>>();

IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
{
	// build graph
	foreach (var word in wordList)
	{
		for (int i = 0; i < word.Length; i++)
		{
			string wordMask = WordToMask(word, i);
			var adjList = g.Keys.Contains(wordMask) ? g[wordMask] : new List<string>();
			adjList.Add(word);
			g[wordMask] = adjList;
		}
	}

	var visited = new HashSet<string>();
	var toVisit = new Queue<(string word, int level)>();
	var ladder = new List<string>();

	toVisit.Enqueue((beginWord, 1));
	
	while (toVisit.Count > 0)
	{
		var node = toVisit.Dequeue();
		if (visited.Contains(node.word))
		{
			continue;
		}
		visited.Add(node.word);
		ladder.Add(node.word);

		for (int i = 0; i < node.word.Length; i++)
		{
			string wordMask = WordToMask(node.word, i);
			if (g.Keys.Contains(wordMask))
			{
				foreach (var child in g[wordMask])
				{
					if (string.Equals(child, endWord))
					{
						ladder.Dump();
					}
					//ladder.RemoveAt(ladder.Count-1);
					toVisit.Enqueue((child, node.level + 1));
				}
			}
		}
	}

	return ladders;
}

string WordToMask(string word, int i)
{
	return $"{word.Substring(0, i)}*{(i == word.Length - 1 ? string.Empty : word.Substring(i + 1, word.Length - (i + 1)))}";
}