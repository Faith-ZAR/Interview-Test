using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public int id { get; set; }
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}
        public void evolve(int statIncrease = 5)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                int initialVal = (stats[i].Value);
                int v = initialVal / statIncrease;
                int newValue = v * initialVal;

                var newKeyValuePair = new KeyValuePair<string, int>(stats[i].Key, newValue);

                stats.RemoveAt(i);
                stats.Insert(i, newKeyValuePair);
            }
        }
    }
}
