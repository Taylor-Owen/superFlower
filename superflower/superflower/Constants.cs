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
            static public byte[] timerCode = { 0x20, 0x5F, 0x8F };
            static public int bubbleBranch = 0x3681; //D0 13 is normal (bne 13)
            static public byte[] bubbleCode = {0xD0, 0x13};
            static public byte[] enableHardMode = { 0xA9, 0x01, 0xEA };
            static public byte[] disableHardMode = { 0xAD, 0xFC, 0x07 };

            //Game Logic
            static public int startingLivesCount = 0x107A;
            static public int startingCoinsCount = 0x0316;
            static public int hardModeCheck = 0x305;

            //Mario
            static public int standingJump = 0x3434;
            static public int walkingJump = 0x3436;
            static public int runningJump = 0x3438;
            static public int runLeftSpeed = 0x3450;
            static public int walkLeftSpeed = 0x3451;
            static public int runRightSpeed = 0x3453;
            static public int walkRightSpeed = 0x3454;

            //Sky Colors
            static public int underwaterSky = 0x05DF; //2-2 and 7-2
            static public int overworldSky = 0x05E0; //1-1, 1-3, 2-1, 2-3, 4-1, 4-3, 5-3, 7-3, 8-1, 8-2 and 8-3. 
            static public int undergroundSky = 0x05E1; //1-2 and 4-2. (Also used for New Level and Game Over screens.) 
            static public int dungeonSky = 0x05E2;
            static public int nighttimeSky = 0x05E3;
            static public int winterDaySky = 0x05E4;
            static public int winterNightSky = 0x05E5;
            static public int sixdashthreeSky = 0x05E6;


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
            static public int textThankYouMario = 0x0D67; //size: 0x10
            static public int textThankYouLuigi = 0x0D7B; //size: 0x10
            static public int textThankYouButOurPrincess = 0x0D8F; //size: 0x16
            static public int textThankYouButOurPrincess2 = 0x0DA8; //size: 0xF
            static public int textYourQuestIsOver = 0x0DBB; //size: 0x13
            static public int textYourQuestIsOver2 = 0x0DD2; //size: 0x1B
            static public int textYourQuestIsOver3 = 0x0DF1; //size: 0xD
            static public int textYourQuestIsOver4 = 0x0E02; //size: 0x11


        }

        static public class Letters
        {
            static public byte A = 0x0A;
            static public byte Minus = 0x28;
            static public byte Copyright = 0xCF;
            static public byte Space = 0x24;
            static public byte Period = 0xAF;
            static public byte Exclamation = 0x2B;
        }

        static public class Opcodes
        {
            static public byte NOP = 0xEA;
        }
    }
}
