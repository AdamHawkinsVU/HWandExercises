using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp
{
    public class Dungeon
    {
        ///title, menu, rooms, room description
        
        public static void Main(string[] args)
        {
            Console.Title = "Dungeon of Doom";
            Console.WriteLine("Your journey begins.... \n");

            bool exit = false;

            do
            {
                Console.WriteLine("\n Please choose an action:" +
                    "\n A) Attack" +
                    "\n R) Run Away" +
                    "\n P) Player Info" +
                    "\n M) Monster Info" +
                    "\n X) Exit\n");


                ConsoleKey userChoice = Console.ReadKey(intercept: true).Key;

                switch (userChoice)
                {
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.R:
                        break;
                    case ConsoleKey.P:
                        break;
                    case ConsoleKey.M:
                        break;
                    case ConsoleKey.X:
                        break;
                    default:
                        Console.WriteLine("Thou hast chosen an improper path. Prithe adventurer take heart and choose again.");
                        break;
                }
            } while (!exit);
        }

    }
}
