using System;

//Creating extra method for calculating functions values ​​(max value and count of iterations) of numbers range (eg, 10 to 10^99). 
//The console must be prompted for range values ​​(start and finish). As results store in array: numbers, maximum (highest) values ​​and the number of iterations of them.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the start of the range: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the end of the range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        int size = end - start +1;
        int[] numbers = new int[size];
        int [] maxValue = new int[size];
        int [] iterationCount = new int[size];

        FibonacciResult calculator = new FibonacciResult(0); //creating an instance of the FibonacciResult class
        for (int i = 0; i < size; i++)
        {
            calculator.n = start + i; //setting the value of n for each number in the range
            calculator.Calculate(); //calculating the Fibonacci sequence for the current value of n
            numbers[i] = start + i; //storing the current number in the numbers array
            maxValue[i] = calculator.MaxValue; //storing the maximum value in the maxValue array
            iterationCount[i] = calculator.IterationCount; //storing the iteration count in the iterationCount array
        }
        Console.WriteLine("Number\tMax Value\tIteration Count");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{numbers[i]}\t{maxValue[i]}\t\t{iterationCount[i]}");
        }
    }
}