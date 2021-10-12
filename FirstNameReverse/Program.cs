using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name!");
            string FirstName = Console.ReadLine();
            if (FirstName.Length > 5)
            {
                for (int i = FirstName.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(FirstName[i]);
                }
            }
            else
            {
                for (int i = 0; i < FirstName.Length; i++)
                {
                    Console.WriteLine(FirstName[i]);
                }
            }


        }
    }
}
