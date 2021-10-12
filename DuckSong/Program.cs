using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {

                if (i > 2)
                {
                    Console.WriteLine($"{i} little ducks went swimming one day");
                    Console.WriteLine("Over the hill and far away");
                    Console.WriteLine("Mother duck said, \"Quack quack quack quack\"");
                    Console.WriteLine($"But only {i - 1} little ducks came back!");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{i} little ducks went swimming one day");
                    Console.WriteLine("Over the hill and far away");
                    Console.WriteLine("Mother duck said, \"Quack quack quack quack\"");
                    Console.WriteLine($"But only {i - 1} little duck came back!");
                }
                else
                {
                    Console.WriteLine($"{i} little duck went swimming one day");
                    Console.WriteLine("Over the hill and far away");
                    Console.WriteLine("Mother duck said, \"Quack quack quack quack\"");
                    Console.WriteLine($"But no little ducks came back!");
                }
            }
            Console.WriteLine("Sad mother duck went out one day");
            Console.WriteLine("Over the hill and far away");
            Console.WriteLine("The sad mother duck said, \"Quack quack quack quack\"");
            Console.WriteLine("And all of the 5 little ducks came back!");
        }
    }
}
