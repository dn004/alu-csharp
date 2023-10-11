using System;

namespace Enemies
{
    class Zombie
    {
        public int  health;
        public int Health{
            get {return health;}
            set{health = value;}
        }  

        public Zombie()
        {
            Health = 0;
        }
    }


}