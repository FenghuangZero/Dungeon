using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class StatBlock
    {
        private int Strength;
        public int STR { get { return Strength; } }
        private int Dexterity;
        public int DEX { get { return Dexterity; } }
        private int Constitution;
        public int CON { get { return Constitution; } }
        private int Wisdom;
        public int WIS { get { return Wisdom; } }
        private int Intelligence;
        public int INT { get { return Intelligence; } }
        private int Charisma;
        public int CHA { get { return Charisma; } }

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

        public StatBlock(double STR, double DEX, double CON, double WIS, double INT, double CHA)
        {
            Strength = (int)STR;
            Dexterity = (int)DEX;
            Constitution = (int)CON;
            Wisdom = (int)WIS;
            Intelligence = (int)INT;
            Charisma = (int)CHA;

        }
    }
}
