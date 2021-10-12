using System;

namespace CakeReplece2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "The c4ke i3 4 l1e";
            cake = cake.Replace('4', 'a');
            cake = cake.Replace('1', 'i');
            cake = cake.Replace('3', 's');
            Console.WriteLine(cake);

        }
    }
}
