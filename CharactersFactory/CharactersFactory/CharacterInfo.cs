using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class CharacterInfo
    {
        public static Character obtainCharacter()
        {
            Console.Clear();
            AskCharacterData characterData = new AskCharacterData();
            Console.WriteLine("--------CHARACTER INFO--------");
            //Obtain Role
            var role = characterData.askData("Role");
            //Obtain Name
            string name = characterData.askData("Name");
            Character character = CharacterFactory.CreateCharacter(role, name);
            return character;

        }
    }
}
