namespace superflower
{
    internal static class Constants
    {
        public static int SMB_Filesize1 = 40976;
        public static class Offsets
        {
            //ASM
            public static int timerDecreaseLogic = 0x37A2; //20 5F 8F is normal
            public static byte[] timerCode = { 0x20, 0x5F, 0x8F };
            public static int bubbleBranch = 0x3681; //D0 13 is normal (bne 13)
            public static byte[] bubbleCode = {0xD0, 0x13};
            public static byte[] enableHardMode = { 0xA9, 0x01, 0xEA };
            public static byte[] disableHardMode = { 0xAD, 0xFC, 0x07 };

            //Game Logic
            public static int startingLivesCount = 0x107A;
            public static int startingCoinsCount = 0x0316;
            public static int hardModeCheck = 0x305;

            //Mario
            public static int standingJump = 0x3434;
            public static int walkingJump = 0x3436;
            public static int runningJump = 0x3438;
            public static int runLeftSpeed = 0x3450;
            public static int walkLeftSpeed = 0x3451;
            public static int runRightSpeed = 0x3453;
            public static int walkRightSpeed = 0x3454;

            //Sky Colors
            public static int underwaterSky = 0x05DF; //2-2 and 7-2
            public static int overworldSky = 0x05E0; //1-1, 1-3, 2-1, 2-3, 4-1, 4-3, 5-3, 7-3, 8-1, 8-2 and 8-3. 
            public static int undergroundSky = 0x05E1; //1-2 and 4-2. (Also used for New Level and Game Over screens.) 
            public static int dungeonSky = 0x05E2;
            public static int nighttimeSky = 0x05E3;
            public static int winterDaySky = 0x05E4;
            public static int winterNightSky = 0x05E5;
            public static int sixdashthreeSky = 0x05E6;


            //Text
            public static int textMario = 0x0765; //size: 0x5
            public static int textWorld = 0x076D; //size: 0x5
            public static int textTime = 0x0774; //size: 0x4
            public static int textWorld2 = 0x0796; //size: 0x5
            public static int textTimeUp = 0x07B3; //size: 0x7
            public static int textGameOver = 0x07C6; //size: 0x9
            public static int textWarpZone = 0x07D3; //size: 0x15
            public static int textLuigi = 0x07FD; //size: 0x5
            public static int textNintendo = 0x9FB5; //size: 0xD
            public static int textOnePlayer = 0x9FC6; //size: 0xD
            public static int textTwoPlayer = 0x9FD6; //size: 0xD
            public static int textTop = 0x9FE6; //size: 0x4
            public static int textThankYouMario = 0x0D67; //size: 0x10
            public static int textThankYouLuigi = 0x0D7B; //size: 0x10
            public static int textThankYouButOurPrincess = 0x0D8F; //size: 0x16
            public static int textThankYouButOurPrincess2 = 0x0DA8; //size: 0xF
            public static int textYourQuestIsOver = 0x0DBB; //size: 0x13
            public static int textYourQuestIsOver2 = 0x0DD2; //size: 0x1B
            public static int textYourQuestIsOver3 = 0x0DF1; //size: 0xD
            public static int textYourQuestIsOver4 = 0x0E02; //size: 0x11


        }

        public static class Letters
        {
            public static byte A = 0x0A;
            public static byte Minus = 0x28;
            public static byte Copyright = 0xCF;
            public static byte Space = 0x24;
            public static byte Period = 0xAF;
            public static byte Exclamation = 0x2B;
        }

        public static class Opcodes
        {
            public static byte NOP = 0xEA;
        }
    }
}
