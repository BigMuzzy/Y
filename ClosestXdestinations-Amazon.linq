<Query Kind="Program" />

void Main()
{
	ClosestXdestinations(
		3,
		new int[,] { { 1, 2 }, { 3, 4 }, { 1, -1}},
		2).Dump();
}

List<List<int>> ClosestXdestinations(
	int numDestinations,
	int[,] allocations,
	int numDeliveries)
{
	var distances = new List<Tuple<int, double>>();
	
	for(int i=0; i< numDestinations; i++)
	{
		var distance = new Tuple<int, double>(i, Math.Sqrt(
			allocations[i, 0] * allocations[i, 0]
			+ allocations[i, 1] * allocations[i, 1]));
		distances.Add(distance);
	}
	
	distances = distances.OrderBy(x => x.Item2).ToList();
	
	List<List<int>> result = new List<List<int>>();
	for (int i = 0; i < numDeliveries; i++)
	{
		var item = new List<int>(){
				allocations[distances[i].Item1,0],
				allocations[distances[i].Item1,1],
			};

		result.Add(item);
	}
	
	return result;
}
