using System;

namespace MyFirstProgram2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            int i;

            int fact = 1;
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

            Console.ReadLine();
        }
    }
}