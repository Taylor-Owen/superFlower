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
            static public int bubbleBranch = 0x3681; //D0 13 is normal (bne 13)

            //Game Logic
            static public int startingLivesCount = 0x107A;
            static public int startingCoinsCount = 0x0316;

            //Mario
            static public int standingJump = 0x3434;
            static public int walkingJump = 0x3436;
            static public int runningJump = 0x3438;

            //Text
            static public int textMario = 0x0765; //size: 0x5
            static public int textWorld = 0x076D; //size: 0x5
            static public int textTime = 0x0774; //size: 0x4
            static public int textWorld2 = 0x0796; //size: 0x5
            static public int textTimeUp = 0x07B3; //size: 0x7
            static public int textGameOver = 0x07C6; //size: 0x9
            static public int textWarpZone = 0x07D3; //size: 0x15
            static public int textLuigi = 0x07FD; //size: 0x5
            static public int textNintendo = 0x9FB5; //size: 0xD
            static public int textOnePlayer = 0x9FC6; //size: 0xD
            static public int textTwoPlayer = 0x9FD6; //size: 0xD
            static public int textTop = 0x9FE6; //size: 0x4
        }
    }
}
