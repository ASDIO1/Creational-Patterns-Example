using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class NameAsker : IAskData<string>
    {
        public string AskData()
        {
            Console.WriteLine("Chose your character Name");
            Console.Write("\nName: ");
            var name = Console.ReadLine();
            Console.WriteLine("");
            return name;
        }
    }
}
