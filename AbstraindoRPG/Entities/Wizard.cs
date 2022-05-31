using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraindoRPG.Entities
{
    public class Wizard : Hero
    {
        private string Name;
        private int Level;
        private int Dano;
        private string HeroType;

        public Wizard(string name, int level)
        {
            Name = name;
            Level = level;
            Dano = level;
            HeroType = "Wizard";
        }

        public override string ToString()
        {
            return Name + " Lv." + Level + " " + HeroType;
        }

        public string Attack()
        {
            return Name + " lançou uma magia! " + Dano.ToString() + " de dano.";
        }
        public string Attack(int mod)
        {
            return Name + " lançou uma magia! " + (Dano + mod).ToString() + " de dano. (modificador: " + mod.ToString() + ").";
        }
    }
}
