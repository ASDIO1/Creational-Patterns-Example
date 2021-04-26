using System;
using System.Collections.Generic;
using System.Threading;

namespace CharactersFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game variables
            List<Character> playerList = new List<Character>();
            Character player;
            var exit = false;

            // First Character creation
            SquadRecruiter.PopulatePlayers(playerList);
            player = playerList[0];

            // Character mini game menu
            while (exit == false)
            {
                PrintStartMenuUI();
                switch (Console.ReadLine())
                {
                    case "1":
                        SquadRecruiter.PopulatePlayers(playerList); // Create more characters
                        break;

                    case "2":
                        Console.WriteLine("\nChose a character by its ID\n");
                        CharacterShowcase.ShowCharacters(playerList);
                        int selection = Convert.ToInt32(Console.ReadLine());

                        if (selection <= playerList.Count)
                        {
                            player = playerList[selection];
                        }
                        else
                        {
                            Console.WriteLine("\nChoose a valid character ID");
                            Thread.Sleep(100);
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nYour actual character is: \n");
                        CharacterShowcase.ShowCharacter(player);
                        Console.WriteLine("\nEnter some key to continue...");
                        Console.ReadKey();
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nChoose a valid option");
                        Thread.Sleep(100);
                        break;
                }
            }

            void PrintStartMenuUI()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("1) Create More Players");
                Console.WriteLine("2) Change player");
                Console.WriteLine("3) Show actual player");
                Console.WriteLine("0) Exit");
                Console.Write("\r\nSelect an option: ");
            }
        }
        
    }
}
