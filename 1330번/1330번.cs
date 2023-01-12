using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Num = Console.ReadLine().Split();

            int NumA = int.Parse(Num[0]);
            int NumB = int.Parse(Num[1]);

            if (NumA > NumB)
            {
                Console.WriteLine(">");
            }
            else if (NumA < NumB)
            {
                Console.WriteLine("<");
            }
            else if (NumA == NumB)
            {
                Console.WriteLine("==");
            }
        }
    }
}
