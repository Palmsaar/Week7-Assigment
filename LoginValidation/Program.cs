using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string ControllUser = "admin";
            string ControllPin = "1234";
            string ControllPass = "Admin";
            string UserName;
            string PassWord;
            string PIN;
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Please enter a Username!");
                UserName = Console.ReadLine();
                Console.WriteLine("Please enter a PIN!");
                PIN = Console.ReadLine();
                Console.WriteLine("Please enter a Password!");
                PassWord = Console.ReadLine();
                if (PIN.Length == 4)
                {

                    if (UserName != ControllUser || PassWord != ControllPass || PIN != ControllPin)
                    {
                        Console.WriteLine($"Incorrect credentials, you have {2 - i} chances left");
                        i++;

                    }
                    else if (UserName == ControllUser && PassWord == ControllPass && PIN == ControllPin)
                    {
                        Console.WriteLine("Welcome!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong, try again");
                }
            }
        }
    }
}
