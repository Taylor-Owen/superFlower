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
            //ASM
            static public int timerDecreaseLogic = 0x37A2; //20 5F 8F is normal

            //Game Logic
            static public int startingLivesCount = 0x107A;
            static public int startingCoinsCount = 0x0316;

            //Mario
            static public int standingJump = 0x3434;
            static public int walkingJump = 0x3436;
            static public int runningJump = 0x3438;
        }
    }
}
