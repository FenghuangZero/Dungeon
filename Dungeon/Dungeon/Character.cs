using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class Character
    {
        private string Name;
        public string name { get { return Name; } set { Name = value; } }

        private CharacterClass Class;
        public string charClass { get { return Class.name;  } }

        private Race Race;
        public string race { get { return Race.name; } }

        private StatBlock Stats;
        public int statStrength { get { return Stats.STR; } }

        public void setRace(Race r)
        {
            Race = r;
        }

        public void setClass(CharacterClass c)
        {
            Class = c;
        }

        public void setStats(StatBlock s)
        {
            Stats = s;
        }

        public Character()
        {}

        public  Character(string name, CharacterClass charClass, Race race, StatBlock stats)
        {
            Name = name;
            Class = charClass;
            Race = race;
            Stats = stats;
        }
    }
}
