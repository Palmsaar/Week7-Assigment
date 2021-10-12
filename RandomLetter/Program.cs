using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Enter your first name!");
            string FirstName = Console.ReadLine();
            int MyRandomNumber = rnd.Next(0, FirstName.Length);
            Console.WriteLine(FirstName[MyRandomNumber]);
        }
    }
}
