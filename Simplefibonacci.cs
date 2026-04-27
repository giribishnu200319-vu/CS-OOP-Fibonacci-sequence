// //Fabionacci sequence
// class Fibonacci
// {
//     public int n;

//     public Fibonacci(int n) //initializing contructor
//     {
//         this.n = n;
//     }

//     public void Calculate() //method to calculate Fibonacci sequence
//     {
//         int a = 0, b = 1, c;
//         Console.WriteLine("Fibonacci sequence: ");
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine(a + " ");
//             c = a + b;
//             a = b;
//             b = c;
//         }
//     }
// }

// //Main Program
// class Program
// {
//     static void Main() 
//     {
//         Console.WriteLine("Enter the number of terms in Fibonacci sequence: "); //user prompt
//         int n = Convert.ToInt32(Console.ReadLine());
//         Fibonacci fibonacci = new Fibonacci(n);
//         fibonacci.Calculate();
//     }
// }
