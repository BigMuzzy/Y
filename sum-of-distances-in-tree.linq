<Query Kind="Program" />

//https://leetcode.com/problems/sum-of-distances-in-tree/

void Main()
{
	var edges = new int[][] {
	new int[]{ 0, 1 },
	new int[]{ 0, 2 },
	new int[]{ 2, 3 },
	new int[]{ 2, 4 },
	new int[]{ 2, 5 } };

	SumOfDistancesInTree(6, edges).Dump();
}

int[] SumOfDistancesInTree(int N, int[][] edges)
{
	int[] result = new int[N];
	bool[] visited;
	for (int i = 0; i < N; i++)
	{
		visited = new bool[N];
		result[i] = Dist(i, 0, edges, visited);
	}
	return result;
}

int Dist(int v, int s, int[][] edges, bool[] visited)
{
	visited[v] = true;
	int result = s;
	for (int i = 0; i < edges.Length; i++)
	{
		if ((edges[i][0] == v && visited[edges[i][1]] == false))
		{
			result += Dist(edges[i][1], s + 1, edges, visited);
		}
		else if((edges[i][1] == v && visited[edges[i][0]] == false))
		{
			result += Dist(edges[i][0], s + 1, edges, visited);
		}
	}

	return result;
}