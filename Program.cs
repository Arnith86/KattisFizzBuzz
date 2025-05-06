/// <summary>
/// This algorithm is a solution to the FizzBuzz problem. 
/// It takes three integer inputs: x, y, and n. And prints the numbers from 1 to n, 
/// replacing multiples of x with "Fizz", and multiples of y with "Buzz". 
/// If they are multiples of both x and y, "FizzBuzz" is printed.
///  
/// I am using the modulo operator (%) to check if the current number is divisible by x, y or both.
/// Starting with checking both x and y, The reason being that it would otherwise exit as soon as it found one or the other.    
/// </summary>

string input;
int[] extractedIntValues = new int[3];

while ((input = Console.ReadLine()) != null) 
{
	Console.Clear();

	// Expected input: Three integer variables x, y, n, separated by spaces
	// x = First integer variable to search for.
	// y = Second integer variable to search for.
	// n = Number of iterations to perform.
	extractedIntValues = Array.ConvertAll(input.Split(' '), int.Parse);

	int x = extractedIntValues[0];
	int y = extractedIntValues[1];
	int n = extractedIntValues[2];

	// If n % m == 0, then n is divisible by m
	for( int i = 1; i < n + 1; i++)
	{
		if ((i % x == 0) && (i % y == 0))
			Console.WriteLine("FizzBuzz");
		else if (i % x == 0)
			Console.WriteLine("Fizz");
		else if (i % y == 0)
			Console.WriteLine("Buzz");
		else
			Console.WriteLine(i);
	}
}


