using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private string name = "(No Name)";
        public string Name
        {
            get { return name; }
            set
            {
                if (name == null)
                {
                    name = "(No Name)";
                }
                else
                {
                    name = value;
                }
            }
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

        public int GetHealth()
        {
            return Health;
        }

        public override string ToString()
        {
            return $"Zombie Name: {Name} / Total Health: {Health}";
        }
    }
}