using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();

            int a = int.Parse(inputA);
            int b = int.Parse(inputB);

            Console.WriteLine((a * b));

        }
    }
}
