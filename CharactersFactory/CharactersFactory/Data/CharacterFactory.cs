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
                case "Flank":// PlayerRole.Flank:
                    return new Flank() { Name = characterName};
                case "Fragger":
                    return new Fragger() { Name = characterName};
                case "Tank":
                    return new Tank() { Name = characterName};
                default:
                    return null;
            }
        }
    }
}
