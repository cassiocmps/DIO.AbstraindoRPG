using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraindoRPG.Entities
{
    public interface Hero
    {
        public string Attack();
        public string Attack(int mod);
    }
}
