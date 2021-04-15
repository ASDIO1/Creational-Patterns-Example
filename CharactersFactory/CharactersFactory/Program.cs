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
                        //PlayerSquadFactory.populatePlayers(playerList);//CREAR MAS PERSONAJES
                        break;
                    case "2":
                        //player = CharacterSelector.selectCharacter(playerList);//returns a character from list

                        break;
                    default:
                        break;
                }
                //print player
            }

            void printStartMenuUI()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create More Players");
                Console.WriteLine("2) Change player");
                Console.Write("\r\nSelect an option: ");
            }
        }
        
    }
}
