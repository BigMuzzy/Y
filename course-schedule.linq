<Query Kind="Program" />

//https://leetcode.com/problems/course-schedule/

void Main()
{
	var pr = new int[][]{ new []{0, 1},
	new []{1, 0}};
	CanFinish(2, pr).Dump();
}
bool CanFinish(int numCourses, int[][] prerequisites)
{
	//buld graph
	var g = new Dictionary<int, List<int>>();

	foreach (var pair in prerequisites)
	{
		if (g.Keys.Contains(pair[0]))
		{
			g[pair[0]].Add(pair[1]);
		}
		else
		{
			g[pair[0]] = new List<int> { pair[1] };
		}
	}

	g.Dump();
	
	HashSet<int> visited = new HashSet<int>();
	bool result = true;
	//run DFS
	foreach (var v in g.Keys)
	{
		result &= Explore(g, v, v, visited);
	}
	return result;
}

bool Explore(Dictionary<int, List<int>> g, int v, int start, HashSet<int> visited)
{
	bool result = true;
	foreach (var u in g[v])
	{
		if (u == start)
		{
			return false;
		}
		if (visited.Contains(u) == false)
		{
			visited.Add(u);
			result &= Explore(g, u, start, visited);
		}
	}

	return result;
}
