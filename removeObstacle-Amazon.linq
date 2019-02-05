<Query Kind="Program" />

void Main()
{
	removeObstacle(3, 3,
	new int[,] {
		{1,0,0},
		{1,0,0},
		{1,9,0}
	}).Dump();
}

int removeObstacle(int numRows, int numColumns, int[,] lot)
{
	int result = -1;
	var visited = new List<int[]>();
	
	var toBeVisited = new Queue<int[]>();
	toBeVisited.Enqueue(new []{0,0});
	
	while(toBeVisited.Count > 0)
	{
		var point = toBeVisited.Dequeue();
		if(visited.Any(x => x[0] == point[0] && x[1] == point[1]) == false)
		{
			visited.Add(point);
			result = result + 1;
			if(lot[point[0],point[1]] == 9)
			{
				return result;
			}
			else
			{
				var row = point[0];
				var col = point[1];
				//step left
				if (col > 0 && lot[row, col - 1] != 0)
				{
					toBeVisited.Enqueue(new[] { row, col - 1});
				}
				//step right
				if (col < (numColumns - 1) && lot[row, col + 1] != 0)
				{
					toBeVisited.Enqueue(new[] { row, col + 1});
				}
				//step up
				if (row > 0 && lot[row - 1, col] != 0)
				{
					toBeVisited.Enqueue(new[] { row - 1, col} );
				}
				//step down
				if (row < (numRows - 1) && lot[row + 1, col] != 0)
				{
					toBeVisited.Enqueue(new[] { row + 1, col} );
				}
			}
		}
	}
	
	return -1;
}
