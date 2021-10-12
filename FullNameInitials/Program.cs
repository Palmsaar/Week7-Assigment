using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine().ToUpper();
            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine().ToUpper();
            //char FirstInt = FirstName[0];
            //char LastInt = LastName[0];
            Console.WriteLine($"Hello {FirstName[0]}.{LastName[0]}.!");
        }
    }
}
