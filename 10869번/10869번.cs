using System;


namespace _10869번
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) % int.Parse(s[1]));
        }
    }
}
