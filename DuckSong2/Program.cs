using System;

namespace DuckSong2
{
    class Program
    {
        static void Main(string[] args)
        {
            string duck = "ducks";
            string OverHill = "Over the hill and far away";
            string Mothersay = "Mother duck said, \"Quack quack quack quack\"";
            for (int i = 5; i > 0; i--)
            {

                if (i > 2)
                {
                    Console.WriteLine($"{i} little {duck} went swimming one day");
                    Console.WriteLine(OverHill);
                    Console.WriteLine(Mothersay);
                    Console.WriteLine($"But only {i - 1} little {duck} came back!");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{i} little {duck} went swimming one day");
                    Console.WriteLine(OverHill);
                    Console.WriteLine(Mothersay);
                    duck = "duck";
                    Console.WriteLine($"But only {i - 1} little {duck} came back!");
                }
                else
                {
                    Console.WriteLine($"{i} little {duck} went swimming one day");
                    Console.WriteLine(OverHill);
                    Console.WriteLine(Mothersay);
                    duck = "ducks";
                    Console.WriteLine($"But no little {duck} came back!");
                }
            }
            Console.WriteLine("Sad mother duck went out one day");
            Console.WriteLine(OverHill);
            Console.WriteLine("The sad mother duck said, \"Quack quack quack quack\"");
            Console.WriteLine("And all of the 5 little ducks came back!");
        }
    }
}
