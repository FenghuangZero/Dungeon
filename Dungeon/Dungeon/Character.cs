using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Character
    {
        private string Name;
        public string name { get { return Name; }  }

        private CharacterClass Class;
        public string charClass { get { return Class.name;  } }

        private Race Race;
        public string race { get { return Race.name; } }

        private StatBlock Stats;

        public  Character(string name, CharacterClass charClass, Race race, StatBlock stats)
        {
            Name = name;
            Class = charClass;
            Race = race;
            Stats = stats;
        }
    }
}
