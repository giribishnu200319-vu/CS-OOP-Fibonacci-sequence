//Fabionacci sequence
class FibonacciResult
{
    public int[] Sequence { get; set; }
    public int MaxValue { get; set; }
    public int IterationCount {get; set;}

    public int n;
    public FibonacciResult(int n) //initializing contructor
    {
        this.n = n;
        this.Sequence = new int[0];
    }

    public void Calculate() //method to calculate Fibonacci sequence
    {
        int[] fibonacciSequence = new int[n];
        int a = 0, b = 1, c;
        int maxValue = 0;
        int iterationCount = 0;
        Console.WriteLine("Fibonacci sequence: "); //user prompt
        for (int i = 0; i < n; i++)
        {
            if (a > maxValue)
            {
                maxValue = a;
            }
            Console.WriteLine(a + " ");
            c = a + b;
            a = b;
            b = c;
            iterationCount++;
        }
        this.Sequence = fibonacciSequence;
        this.MaxValue = maxValue;
        this.IterationCount = iterationCount;
    }
}
