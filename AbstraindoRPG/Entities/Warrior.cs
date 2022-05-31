using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraindoRPG.Entities
{
    public class Warrior : Hero
    {
        private string Name;
        private int Level;
        private int Dano;
        private string HeroType;

        public Warrior(string name, int level)
        {
            Name = name;
            Level = level;
            Dano = level;
            HeroType = "Warrior";
        }

        public override string ToString()
        {
            return Name + " Lv." + Level + " " + HeroType;
        }

        public string Attack()
        {
            return Name + " atacou com a sua espada! " + Dano.ToString() + " de dano.";
        }
        public string Attack(int mod)
        {
            return Name + " atacou com a sua espada! " + (Dano+mod).ToString() + " de dano. (modificador: " + mod.ToString() + ").";
        }
    }
}
