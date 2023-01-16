using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

                if(a >= 90 & a <= 100)
                {
                    Console.WriteLine("A");
                }
                else if(a >= 80)
                {
                    Console.WriteLine("B");
                }
                else if(a >= 70)
                {
                    Console.WriteLine("C");
                }
                else if(a >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }   
        }
    }
}
