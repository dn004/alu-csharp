using System;


namespace Enemies
{
    class Zombie
    {
        public int  health;
        public int Health{
            get {return health;}
            set
            {health = value;}
        }  

        public Zombie()
        {
            Health = 0;
        }

        public Zombie(int value)
        {
            if (value >= 0)
                {
                    health = value;
                }
            else if (value < 0)
                {
                    throw new ArgumentException("Health must be greater than or equal to 0");
                }
        }
    }


}