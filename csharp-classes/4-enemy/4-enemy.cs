﻿using System;

namespace Enemies
{
    class Zombie
    {
        private int  health;
        public int Health{
            get {return health;}
            set
            {health = value;}
        } 

        private string name = "(No Name)";
        public string Name
        {
            get {return name;}
            set{name = value;}
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
    }
}