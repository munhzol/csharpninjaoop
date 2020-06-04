using System;

namespace Human.Models
{

    class Wizard : Human
    {
        public Wizard(string name): base(name)
        {
            Health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public int Heal(Human target)
        {
            int heal = Intelligence * 5;
            target.Health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal} heal!");
            return target.Health;
        }



    }

}
