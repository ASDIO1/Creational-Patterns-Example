using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class CharacterInfo
    {
        public static Character ObtainCharacterData()
        {
            // Console.Clear();
            RoleAsker roleData = new RoleAsker();
            NameAsker nameData = new NameAsker();
            Console.WriteLine("\n--------CHARACTER INFO--------");
            var role = roleData.AskData();//Obtain Role
            string name = nameData.AskData();//Obtain Name
            Character character = CharacterFactory.CreateCharacter(role, name);
            return character;
        }
    }
}
