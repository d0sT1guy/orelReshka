using System;
using static System.Console;

namespace gladiatorsBet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;
            Random rand = new Random();
            float health1 = rand.Next(1, 100);
            int armor1 = rand.Next(1, 100);
            int damage1 = rand.Next(1, 100);

            float health2 = rand.Next(1, 100);
            int armor2 = rand.Next(1, 100);
            int damage2 = rand.Next(1, 100);

            WriteLine($"Gladiator 1 has {health1} health, {armor1} armor and {damage1} damage!");
            Console.ReadKey();
            WriteLine($"Gladiator 2 has {health2} health, {armor2} armor and {damage2} damage!");
            Console.ReadKey();
            WriteLine("Who will win????");
            Console.ReadKey();

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

                WriteLine("Health Gladiator 1: " + health1);
                Console.ReadKey();
                WriteLine("Health Gladiator 2: " + health2);
                Console.ReadKey();

                if (health1 <= 0 && health2 <= 0)
                {
                    WriteLine("Tie!!!!");
                }

                else if (health1 < 0)
                {
                    WriteLine("Gladiator 2 win! He has a " + health2 + " health!");
                    break;
                }
                else if (health2 < 0)
                {
                    WriteLine("Gladiator 1 win! He has a " + health1 + " health!");
                    break;
                }
            }
        }
    }
}

