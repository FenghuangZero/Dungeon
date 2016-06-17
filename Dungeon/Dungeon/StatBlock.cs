using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class StatBlock
    {
        private int Strength;
        private int Dexterity;
        private int Constitution;
        private int Wisdom;
        private int Intelligence;
        private int Charisma;

        public void addSTR(int stat)
        {
            Strength += stat;
        }

        public void addDEX(int stat)
        {
            Dexterity += stat;
        }

        public void addCON(int stat)
        {
            Constitution += stat;
        }

        public void addWIS(int stat)
        {
            Wisdom += stat;
        }

        public void addINT(int stat)
        {
            Intelligence += stat;
        }

        public void addCHA(int stat)
        {
            Charisma += stat;
        }

        public StatBlock(int STR, int DEX, int CON, int WIS, int INT, int CHA)
        {
            Strength = STR;
            Dexterity = DEX;
            Constitution = CON;
            Wisdom = WIS;
            Intelligence = INT;
            Charisma = CHA;

        }
    }
}
