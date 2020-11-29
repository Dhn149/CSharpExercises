using System;

namespace primo_esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            /* primo esercizio svolto 
            Console.WriteLine("Please, insert your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name.ToUpper()}");
            */

            string catchArgs = args[0];
            var args1 = catchArgs.ToUpper();
            System.Console.WriteLine($"This is my argument to upper {args1}");
        }
    }
}
