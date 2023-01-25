using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] time = Console.ReadLine().Split();

            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);

            if (h <= 0 || h <= 23 || m <= 0 || m <= 59)
            {
                if (m < 45)
                {
                    if (h <= 0)
                    {
                        h += 24;
                        m += 15;
                        h--;
                    }
                    else
                    {
                        m += 15;
                        h--;
                    }
                }
              
                else
                {
                    m -= 45;
                }
            }


            Console.WriteLine($"{h} {m}");
        }
    }
}
