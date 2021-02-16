using System;

namespace ConditionsEX4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("identifiant: ");
            string login = Console.ReadLine();
            Console.Write("mot de passe: ");
            string password = Console.ReadLine();
            int caseswitch = 0; 
            if ( login == "halima" && password == "lamanu")
            {
                caseswitch = 1; 
            }

            switch (caseswitch)
            {
                case 0: Console.WriteLine("« Mauvais identifiant ou mauvais mot de passe. »"); break;
                case 1: Console.WriteLine("« Bienvenue à la Manu. »"); break;
            }
            
        }
    }
}
