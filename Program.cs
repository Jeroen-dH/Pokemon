using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        bool YesOrNo = true;

        charmander charmander = new charmander("Charmander", "fire", "water", 100);

        while (YesOrNo)
        {
            Console.WriteLine("Enter charmander's name:");
            string PokemonName = Console.ReadLine();
            charmander.setName(PokemonName);


            Console.WriteLine("Name: " + charmander.getName());
            Console.WriteLine("Type: " + charmander.getType());
            Console.WriteLine("Weakness: " + charmander.weakness);
            Console.WriteLine("HP: " + charmander.hp);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("battle cry: " + PokemonName);
            }

            Console.WriteLine("Do you want to continue? (y/n):");
            string awnser = Console.ReadLine();
            if (awnser == "y")
            {
                YesOrNo = true;
            }
            else
            {
                YesOrNo = false;
            }
        }
    }
}