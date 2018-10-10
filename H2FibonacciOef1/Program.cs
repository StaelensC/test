using System;

namespace H2FibonacciOef1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Welk getal uit de rij van Fibonacci wilt u kennen?");
            int index = int.Parse(Console.ReadLine());
            result = GetFibonacci(index);
            Console.WriteLine($"Het getal dat u zocht is {result}");
            

        }

        private static int GetFibonacci(int index) {
            if (index == 1 || index == 2)
                return --index;
            int Fibonacci1 = 0;
            int Fibonacci2 = 1;
            int result = 0;
            while (index > 2) {
                result = Fibonacci1 + Fibonacci2;
                Fibonacci1 = Fibonacci2;
                Fibonacci2 = result;
                
                index--;
            }
            return result;
        }
    }
}
