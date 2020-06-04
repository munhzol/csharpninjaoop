using System;

namespace Human.Models
{

    class Samurai : Human
    {
        public Samurai(string name): base(name)
        {
            Health = 200;
        }

        public override int Attack(Human target)
        {
            int target_health = base.Attack(target);
            if(target_health<50)
                target.Health = 0;
            return target.Health;
        }
        
        public int Meditate()
        {
            Health = 200;
            return Health;
        }

    }

}
