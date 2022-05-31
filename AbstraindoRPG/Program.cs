using AbstraindoRPG.Entities;
using System;

namespace AbstraindoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Warrior("Arus", 12);
            Hero jen = new Wizard("Jen", 13);
            Console.WriteLine(arus);
            Console.WriteLine(jen);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jen.Attack());

            Console.WriteLine(arus.Attack(5));
        }
    }
}
