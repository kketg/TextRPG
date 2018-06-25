using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class PlayerClass
    {
        public string Name;
        public float healthWeight;
        public float strWeight;
        public float agiWeight;
        public float intWeight;
        public float defWeight;


        public PlayerClass(string name,float healthWeight, float strWeight, float agiWeight, float intWeight, float defWeight)
        {
            Name = name;
            this.healthWeight = healthWeight;
            this.strWeight = strWeight;
            this.agiWeight = agiWeight;
            this.intWeight = intWeight;
            this.defWeight = defWeight;
        }
    }
}
