using System;
using Human.Models;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Wizard");
            Ninja ninja = new Ninja("Ninja");
            Samurai samurai = new Samurai("Samurai");

            Console.WriteLine("1. ************************************");
            Console.WriteLine("*** Init ***");
            wizard.ShowInfo();
            ninja.ShowInfo();
            samurai.ShowInfo();
            Console.WriteLine("");

            Console.WriteLine("2. ************************************");
            Console.WriteLine("*** Ninja stole from Wizard ***");
            ninja.Steal(wizard);
            wizard.ShowInfo();
            ninja.ShowInfo();
            samurai.ShowInfo();
            Console.WriteLine("");

            Console.WriteLine("3. ************************************");
            Console.WriteLine("*** Wizard attacked Ninja ***");
            wizard.Attack(ninja);
            wizard.ShowInfo();
            ninja.ShowInfo();
            samurai.ShowInfo();
            Console.WriteLine("");

            Console.WriteLine("4. ************************************");
            Console.WriteLine("*** Samurai attacked Wizard ***");
            samurai.Attack(wizard);
            wizard.ShowInfo();
            ninja.ShowInfo();
            samurai.ShowInfo();
            Console.WriteLine("");

        }
    }
}
