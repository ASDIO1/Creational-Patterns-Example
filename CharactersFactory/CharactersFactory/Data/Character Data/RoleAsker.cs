using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class RoleAsker : IAskData<string>
    {
        public string AskData()
        {
            Console.WriteLine("Chose a character role");
            var index = 1;
            SubclassObtainer subclases = new SubclassObtainer();
            List<string> roles = subclases.ObtainSubclasses("Character");

            foreach (var role in roles)
            {
                Console.WriteLine($"{index}) {role}");
                index++;
            }

            Console.Write("\nSelect role: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return roles[selection - 1];
        }
    }
}
