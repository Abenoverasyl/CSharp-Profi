using System;

namespace DinamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Mosh";
            name = 10;
            name++;
            Console.WriteLine(name);


            int a = 5;
            dynamic b = a;
            long c = b;

            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}
