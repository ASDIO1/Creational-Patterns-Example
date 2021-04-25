using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class CharacterShowcase
    {
        public static void showCharacters(List<Character> characterList)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < characterList.Count; i++)
            {

                var c = characterList[i];
                Console.Write($"{i}) ");
                showCharacter(c);
                Console.WriteLine();
            }
        }
        public static void showCharacter(Character character)
        {
            StringBuilder characterData = new StringBuilder();
            characterData.Append($"Name: {character.Name} | Health {character.Health} | ");
            characterData.Append($"action: {character.Action} | role: {character.GetType().Name}");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(characterData);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
