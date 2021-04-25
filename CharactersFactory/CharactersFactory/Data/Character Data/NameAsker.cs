using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class NameAsker : IAskData<string>
    {
        public string askData()
        {
            Console.WriteLine("Chose your character name");
            Console.Write("\nName: ");
            var name = Console.ReadLine();
            Console.WriteLine("");
            return name;
        }
    }
}
