<Query Kind="Program" />

void Main()
{
	
	var a = new int[]{ 8,7,3,5,0,2,1,6,4};
	
	MergeSort(a).Dump();
	
}

int[] MergeSort(int[] a)
{
	if(a.Length <  2)
	{
		return a;
	}

	var left = new int[a.Length / 2];
	var right = new int[a.Length - (a.Length / 2)];

	Array.Copy(a, left, a.Length / 2);
	Array.Copy(a, a.Length / 2, right, 0, a.Length - (a.Length / 2));

	return Merge(MergeSort(left), MergeSort(right));
}

int[] Merge(int[] a, int[] b)
{
	int i = 0;
	int j = 0;
	
	var c = new int[a.Length + b.Length];
	
	for(int k = 0; k < c.Length; k++)
	{
		if (i < a.Length && j < b.Length)
		{
			if (i < a.Length && a[i] > b[j])
			{
				c[k] = b[j];
				j++;
			}
			else
			{
				c[k] = a[i];
				i++;
			}
		}
		else
		{
			if(i < a.Length)
			{
				c[k] = a[i];
				i++;
			}
			else
			{
				c[k] = b[j];
				j++;
			}
			
		}
	}
	return c;
}
