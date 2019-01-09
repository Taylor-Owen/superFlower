using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superflower
{
    static class Constants
    {
        static public int SMB_Filesize1 = 40976;
        static public class Offsets
        {
            static public int standingJump = 0x3434;
            static public int walkingJump = 0x3436;
            static public int runningJump = 0x3438;
        }
    }
}
