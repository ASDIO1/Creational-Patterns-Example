using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class Character
    {
        public enum Actions
        {
            Standing,
            Covered
        }
        public Character()
        {
            Action = Actions.Standing;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public Actions Action { get; set; }
    }
}
