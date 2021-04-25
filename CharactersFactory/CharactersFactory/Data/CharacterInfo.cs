﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class CharacterInfo
    {
        public static Character obtainCharacter()
        {
            // Console.Clear();
            RoleAsker roleData = new RoleAsker();
            NameAsker nameData = new NameAsker();
            Console.WriteLine("\n--------CHARACTER INFO--------");
            var role = roleData.askData();//Obtain Role
            string name = nameData.askData();//Obtain Name
            Character character = CharacterFactory.CreateCharacter(role, name);
            return character;
        }
    }
}
