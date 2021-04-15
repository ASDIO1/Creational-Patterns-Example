using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class CharacterFactory
    {
        public static Character CreateCharacter(string role, string characterName)
        {
            switch (role)
            {
                case "Flank":/*PlayerRole.Flank:*/
                    return new Flank() { name = characterName};
                case "Fragger":
                    return new Fragger() { name = characterName};
                case "Tank":
                    return new Tank() { name = characterName};
                default:
                    return null;
            }
        }
    }
}
