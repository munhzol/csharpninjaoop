using System;

namespace Human.Models
{

    class Ninja : Human
    {
        public Ninja(string name): base(name)
        {
            Dexterity=175;
        }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;

            Random rnd = new Random();
            if(rnd.Next(100)<21)
                dmg +=10;

            target.Health -= dmg;
            Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} stole 5 health from {target.Name}!");
            return target.Health;
        }

    }

}
