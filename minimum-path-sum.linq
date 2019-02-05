<Query Kind="Program" />

// https://leetcode.com/problems/minimum-path-sum/
void Main()
{
	int[,] grid = {
	{5,0,1,1,2,1,0,1,3,6,3,0,7,3,3,3,1},
	{1,4,1,8,5,5,5,6,8,7,0,4,3,9,9,6,0},
	{2,8,3,3,1,6,1,4,9,0,9,2,3,3,3,8,4},
	{3,5,1,9,3,0,8,3,4,3,4,6,9,6,8,9,9},
	{3,0,7,4,6,6,4,6,8,8,9,3,8,3,9,3,4},
	{8,8,6,8,3,3,1,7,9,3,3,9,2,4,3,5,1},
	{7,1,0,4,7,8,4,6,4,2,1,3,7,8,3,5,4},
	{3,0,9,6,7,8,9,2,0,4,6,3,9,7,2,0,7},
	{8,0,8,2,6,4,4,0,9,3,8,4,0,4,7,0,4},
	{3,7,4,5,9,4,9,7,9,8,7,4,0,4,2,0,4},
	{5,9,0,1,9,1,5,9,5,5,3,4,6,9,8,5,6},
	{5,7,2,4,4,4,2,1,8,4,8,0,5,4,7,4,7},
	{9,5,8,6,4,4,3,9,8,1,1,8,7,7,3,6,9},
	{7,2,3,1,6,3,6,6,6,3,2,3,9,9,4,4,8}};

	MinPathSum(grid).Dump();
}

int MinPathSum(int[,] grid)
{
	int[,] cost = new int[grid.GetLength(0), grid.GetLength(1)];

	for (int i = 0; i < cost.GetLength(0); i++)
	{
		for (int j = 0; j < cost.GetLength(1); j++)
		{
			cost[i, j] = -1;
		}
	}
	cost[grid.GetLength(0) - 1, grid.GetLength(1) - 1] = grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1];

	return F(0, 0, grid, cost);

	//return grid[0,0];
}

int F(int i, int j, int[,] grid, int[,] cost)
{
	if (cost[i, j] >= 0)
	{
		return cost[i, j];
	}

	if (i == (grid.GetLength(0) - 1))
	{
		cost[i, j] = grid[i, j] + F(i, j + 1, grid, cost);
		return cost[i, j];
	}
	else if (j == (grid.GetLength(1) - 1))
	{
		cost[i, j] = grid[i, j] + F(i + 1, j, grid, cost);
		return cost[i, j];
	}

	cost[i, j] = grid[i, j] + Math.Min(F(i + 1, j, grid, cost), F(i, j + 1, grid, cost));
	return cost[i, j];
}

void F1(int[,] grid)
{
	for (int i = grid.GetLength(0) - 1; i >= 0; i--)
	{
		for (int j = grid.GetLength(1) - 1; j >= 0; j--)
		{
			if (i == (grid.GetLength(0) - 1) &&
				j == (grid.GetLength(1) - 1))
			{
				continue;
			}
			else if (i == (grid.GetLength(0) - 1))
			{
				grid[i, j] = grid[i, j] + grid[i, j + 1];
			}
			else if (j == (grid.GetLength(1) - 1))
			{
				grid[i, j] = grid[i, j] + grid[i + 1, j];
			}
			else
			{
				grid[i, j] = grid[i, j] + Math.Min(grid[i, j + 1], grid[i + 1, j]);
			}
		}
	}
}