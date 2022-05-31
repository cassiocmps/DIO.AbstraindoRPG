using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraindoRPG.Entities
{
    public class Arus
    {
        private string Name;
        private int Level;
        private string HeroType;

        public Arus(string name, int level, string type)
        {
            Name = name;
            Level = level;
            HeroType = type;
        }
    }
}
