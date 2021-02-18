using System;

namespace ConditionsEX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Password: ");
            string str2 = Console.ReadLine();

            switch ((str1, str2))
            {
                case ("toto", "tata"): Console.WriteLine("Bienvenue à la Manu"); break;

            }
        }
    }
}
