using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Entity
    {
        public string Name;
        public float health;
        public float maxHealth;
        public int level;
        public bool isFriendly;

        public Entity(string name, float health, float maxHealth,int level, bool friendly)
        {
            Name = name;
            this.health = health;
            this.maxHealth = maxHealth;
            this.level = level;
            isFriendly = friendly;
        }
    }
}
