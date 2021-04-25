using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CharactersFactory
{
    class SquadRecruiter
    {
        public static void populatePlayers(List<Character> playerList)
        {

            bool exit = false;
            while (exit == false)
            {
                showPlayersCreatorMenu();
                switch (Console.ReadLine())
                {
                    case "1":
                        var player = CharacterInfo.obtainCharacter();
                        playerList.Add(player);
                        Console.WriteLine("player added...");
                        Thread.Sleep(100);
                        break;
                    case "2":
                        if (playerList.Count >= 1)
                        {
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("\nCREATE AT LEAST 1 CHARACTER !");
                            Thread.Sleep(1000);  //waits 1sec befor continuing
                        }
                        break;
                    default:
                        break;
                }
            }

        }
        public static void showPlayersCreatorMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------CHARACTER CREATOR------------------");
            Console.WriteLine("Choose an option:\n");
            Console.WriteLine("1) Create Player");
            Console.WriteLine("2) Continue");
            Console.Write("\nOption: ");
        }
    }
}
