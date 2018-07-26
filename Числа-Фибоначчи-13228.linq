<Query Kind="Program" />

// https://stepik.org/lesson/Числа-Фибоначчи-13228/step/6?unit=3414

void Main()
{
	int n;
	n = int.Parse(Console.ReadLine());
	int result = Fib(n);
	Console.WriteLine(result);
}

int Fib(int n)
{
	if(n == 1) {
		return 1;
	}
	
	int a = 0;
	int b = 1;
	int c = 0;

	for (int i = 2; i <= n; i++)
	{
		c = a + b;
		a = b;
		b = c;
	}
	
	return c;
}
