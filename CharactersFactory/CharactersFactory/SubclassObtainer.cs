using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharactersFactory
{
    class SubclassObtainer
    {
        public List<string> ObtainSubclasses(string superclassType)
        {
            System.Reflection.Assembly assembly;// = typeof(Drink).Assembly; //Default value
            Type baseType;
            if (superclassType == "Character")
            {
                assembly = typeof(Character).Assembly;
                baseType = typeof(Character);
            }
            else
            {
                assembly = typeof(Character).Assembly;
                baseType = typeof(Character);
            }
            List<string> types = assembly.GetTypes()                 //gets all direct subclasses string names in a list
                .Where(t => t.BaseType == baseType)
                .Select(t => t.Name)  //gets the subclass name string prettyfied 
                .ToList();
            return types;
        }
    }
}
