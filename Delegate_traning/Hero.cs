using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_training
{
    class Hero : Charapter
    {
        public string Name { get; }
        public int HP { get ; set ; }
        public int Damage { get ; set ; }
        public int Experience { get ; set ; }
        public byte Level { get ; set ; }
        public int LevelBoundary { get; set; } = 100;

        public Hero(string name, int dmg, int hp, int exp, byte lvl)
        {
            Name = name;
            Damage = dmg;
            HP = hp;
            Experience = exp;
            Level = lvl;
        }

        public byte LevelUp(byte onelvl)
        {
            if (Experience >= LevelBoundary & levelUpHandler != null)
            {
                Experience -= LevelBoundary;
                return levelUpHandler(Level++);
            }
            else return Level;///
        }

        public int ExperienceUp()
        {
            throw new NotImplementedException();
        }

        public int HPUp()
        {
            throw new NotImplementedException();
        }

        public int HDDown()
        {
            throw new NotImplementedException();
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public delegate byte LevelUpHandler(byte onelvl);
        private LevelUpHandler levelUpHandler;
        public void RegisterWithLevelUp(LevelUpHandler methodToCall)
        { levelUpHandler = methodToCall; }
    }
}
