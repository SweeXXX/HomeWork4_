using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Library
    {
        public enum LevelOfGrouchiness
        {
            low = 0,
            midle = 1,
            high = 2
        }
        public struct GrandFather
        {
            public string Name;
            public int CountOfBruise=0;
            public LevelOfGrouchiness LevelOfGrouchiness;
            public string[] masBr = new string[] { "Сталина на вас не хватает! "};
            public GrandFather(string Name, LevelOfGrouchiness LevelOfGrouchiness, string[] masBr)
            {
                this.Name = Name;
 
                this.LevelOfGrouchiness = LevelOfGrouchiness;
                this.masBr = masBr;
            }
        }
    }
}
