using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "The c4ke i3 4 l1e";
            for (int i = 0; i < cake.Length; i++)
            {
                if (cake[i] == '3')
                {
                    Console.Write("s");
                }
                else if (cake[i] == '4')
                {
                    Console.Write("a");
                }
                else if (cake[i] == '1')
                {
                    Console.Write("i");
                }
                else
                {
                    Console.Write(cake[i]);
                }
            }
        }
    }
}
