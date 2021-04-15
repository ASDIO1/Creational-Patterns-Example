using System;
using System.Collections.Generic;

namespace CharactersFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game variables
            List<Character> playerList = new List<Character>();
            Character player;
            var exit = false;
            while (exit == false)
            {
                printStartMenuUI();
                switch (Console.ReadLine()) // Char valuetype that represents a keyboard key
                {
                    case "1":
                        SquadRecruiter.populatePlayers(playerList);//CREAR MAS PERSONAJES
                        break;
                    case "2":
                        Console.WriteLine("\nChose a character by its number");
                        CharacterShowcase.showCharacters(playerList);
                        player = playerList[Convert.ToInt32(Console.ReadLine())];
                        break;
                    case "3":
                        //print actual player
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        player = playerList[0];
                        break;
                }
            }

            void printStartMenuUI()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create More Players");
                Console.WriteLine("2) Change player");
                Console.WriteLine("3) Show actual player");
                Console.WriteLine("0) Exit");
                Console.Write("\r\nSelect an option: ");
            }
        }
        
    }
}
