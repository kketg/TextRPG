using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Location
    {
        //public string locationDesc = "";
        
        public List<Direction> dirs;

        static Random rand = new Random();
        int l = rand.Next(0, 5);

        public Location()
        {
            
            dirs = new List<Direction>();
            for(int i = 0; i < l; i++){
                Direction d = new Direction();
                dirs.Add(d);
                
            }
            foreach(Direction d in dirs)
            {
                d.LeadsFrom = this;
                Console.WriteLine(d);
            }
                
            
        }

    }
}
