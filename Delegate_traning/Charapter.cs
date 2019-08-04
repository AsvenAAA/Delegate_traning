using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_training
{
    interface Charapter
    {
        string Name { get; }
        int HP { get; set; }
        int Damage { get; set; }
        int Experience { get; set; }
        byte Level { get; set; }
        int LevelBoundary { get; set; }

        byte LevelUp(byte onelvl);
        int ExperienceUp();
        int HPUp();
        int HDDown();
        int Attack();
    }
}
