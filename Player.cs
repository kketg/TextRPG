using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Player
    {
        public string Name;
        public float health;
        public float maxHealth;
        public float Mana;
        public float maxMana;
        public float xp;
        public float maxXp;
        public int level;
        public float STR;
        public float AGI;
        public float INT;
        public float DEF;
        public float SAN;

        public Player(string Name, float health, float maxHealth, float Mana, float maxMana, float xp, float maxXp, int level, float STR, float AGI, float INT, float DEF, float SAN)
        {
            this.Name = Name;
            this.health = health;
            this.maxHealth = health;
            this.Mana = Mana;
            this.maxMana = maxMana;
            this.xp = xp;
            this.maxXp = maxXp;
            this.level = level;
            this.STR = STR;
            this.AGI = AGI;
            this.INT = INT;
            this.DEF = DEF;
            this.SAN = SAN;
        }
    }

    
}
