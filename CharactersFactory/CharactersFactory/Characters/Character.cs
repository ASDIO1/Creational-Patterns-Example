using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersFactory
{
    class Character
    {
        public enum Action
        {
            Standing,
            Covered
        }
        public Character()
        {
            action = Action.Standing;
        }
        public string name { get; set; }
        public int health { get; set; }
        public Action action { get; set; }
    }
}
