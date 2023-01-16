using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            int numA = int.Parse(a[0]);
            int numB = int.Parse(a[1]);

            if(numA > numB)
            {
                Console.WriteLine(">");
            }
            else if(numA == numB)
            {
                Console.WriteLine("==");
            }
            else if (numA < numB)
            {
                Console.WriteLine("<");
            }
        }
    }
}
